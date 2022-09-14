#include <String.h>


String inputString = "";
bool stringComplete = false;
String commandString = "";


int led1Pin = 8;
int led2Pin = 9;
int led3Pin = 10;

bool isConnected;
LiquidCrystal_I2C lcd(0x27, 16, 2);

// NHIET DO- DO AM
const int DHTPIN = 2;
const int DHTTYPE = DHT11;
DHT dht(DHTPIN, DHTTYPE);

// CONTACTOR
int contactorPin = 11;



void setup() {
    // put your setup   code here, to run once:
    Serial.begin(9600);
    pinMode(led1Pin, OUTPUT);
    pinMode(led2Pin, OUTPUT);
    pinMode(led3Pin, OUTPUT);
    pinMode(contactorPin, INPUT_PULLUP);

    lcd.init();
    lcd.backlight();

    lcd.print("readdy ");
    initDisplay();

    dht.begin();
}

void loop() {
    // put your main code here, to run repeatedly:
    if (stringComplete)
    {
        stringComplete = false;
        getCommand();

        if (commandString == "STAR")
        {
            lcd.clear();
        }
        else if (commandString == "STOP")
        {
            turnLedOff(led1Pin);
            turnLedOff(led2Pin);
            turnLedOff(led3Pin);
            lcd.clear();
            lcd.print("ready connect");
        }
        else if (commandString == "TEXT")
        {
            String text = getTextToPrint();
            printText(text);
        }
        else if (commandString == "LED1")
        {
            bool LedState = getLedState();
            if (LedState == true)
            {
                Serial.println("LED1 ON");
                turnLedOn(led1Pin);
            }
            else turnLedOff(led1Pin);
        }
        else if (commandString == "LED2")
        {
            bool LedState = getLedState();
            if (LedState == true)
            {
                Serial.println("LED2 ON");
                turnLedOn(led2Pin);
            }
            else turnLedOff(led2Pin);
        }
        else if (commandString == "LED3")
        {
            bool LedState = getLedState();
            if (LedState == true)
            {
                Serial.println("LED3 ON ");
                turnLedOn(led3Pin);
            }
            else
            {
                Serial.println("LED3 oFF");
                turnLedOff(led3Pin);
            }
        }
        inputString = "";
    }
    hienThiDoAmNhietDo();
    batContacTor(contactorPin, led3Pin);
}
void batContacTor(int inPin, int OutPin)
{
    int val = digitalRead(inPin);   // read the input pin
    digitalWrite(OutPin, val);  // sets the LED to the button's value
    Serial.println(val);
}
void hienThiDoAmNhietDo()
{
    float h = dht.readHumidity();
    float t = dht.readTemperature();

    if (isnan(t) || isnan(h)) { // Kiểm tra xem thử việc đọc giá trị có bị thất bại hay không. Hàm isnan bạn xem tại đây http://arduino.vn/reference/isnan
    }
    else {
        lcd.setCursor(10, 0);
        lcd.print(round(t));
        lcd.print(" ");
        lcd.write(1);
        lcd.print("C");

        lcd.setCursor(10, 1);
        lcd.print(round(h));
        lcd.print(" %");
    }
}
void initDisplay()
{
    lcd.begin(16, 2);
    lcd.print("ready to connect");
}
bool getLedState()
{
    bool state = false;
    Serial.println("inputString :" + inputString);
    String stateString = inputString.substring(5, 7);
    Serial.println("stateString :" + stateString);
    if (stateString == "ON")
        state = true;
    else state = false;
    return state;
}
void getCommand()
{
    if (inputString.length() > 0)
    {
        commandString = inputString.substring(1, 5);
        Serial.println("commandString: " + commandString);
    }
}
String getTextToPrint()
{
    String value = inputString.substring(5, inputString.length() - 2);
    return value;
}
void turnLedOff(int pin)
{
    digitalWrite(pin, LOW);
}
void turnLedOn(int pin)
{
    digitalWrite(pin, HIGH);
}
void printText(String text)
{
    lcd.clear();
    lcd.setCursor(0, 0);
    if (text.length() < 16)
    {
        lcd.print(text);
    }
    else
    {
        lcd.print(text.substring(0, 16));
        lcd.setCursor(0, 1);
        lcd.print(text.substring(16, 32));
    }
}

void serialEvent() {
    while (Serial.available())
    {
        char inChar = (char)Serial.read();
        inputString += inChar;
        if (inChar == '\n')
        {
            stringComplete = true;
        }
        Serial.println(inputString);
    }
}