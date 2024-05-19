const int buttonPin_1 = 12;
const int buttonPin_2 = 8;

void setup() {
 pinMode(buttonPin_1, INPUT_PULLUP);
 pinMode(buttonPin_2, INPUT_PULLUP);
 
 Serial.begin(9600);
}

void loop() {
  int buttonState_1 = digitalRead(buttonPin_1);
  int buttonState_2 = digitalRead(buttonPin_2);
  
  if(buttonState_1 == LOW)  //臼
  {
    Serial.println("U");
    delay(200);
  }

  if(buttonState_2 == LOW)  //杵
  {
    Serial.println("K");
    delay(200);
  }
}
