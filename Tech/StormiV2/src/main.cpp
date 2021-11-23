#include <Arduino.h>
#include <WiFiNINA.h>
#include <ArduinoHttpClient.h>
#include <ArduinoJson.h>

char SSID[] = "MSI9247";
char PASS[] = "gr3wt2h64";
const char server[] = "145.93.100.146";

WiFiClient wifi;
HttpClient client = HttpClient(wifi, server, 2435);
int status = WL_IDLE_STATUS;

int clientId = 0;

void registerArduino() {
  StaticJsonDocument<8> json;

  json["tafelNummer"] = 1;

  String data;
  serializeJson(json, data);

  client.beginRequest();
  client.post("/register", "application/json", data);

  if(client.responseStatusCode() == 200) {
    StaticJsonDocument<24> response;
    deserializeJson(response, client.responseBody());
    clientId = response["id"];
  }
}

void updateAmperage() {
  StaticJsonDocument<16> json;

  json["clientId"] = clientId;
  json["ampere"] = 100;

  String data;
  serializeJson(json, data);

  client.beginRequest();
  client.post("/update", "application/json", data);

  if(client.responseStatusCode() == 406) {
    registerArduino();
  }
}

void setup()
{
  Serial.begin(9600);

  while (status != WL_CONNECTED)
  {
    Serial.println("Connecting to WiFi...");
    status = WiFi.begin(SSID, PASS);
    delay(500);
  }

  Serial.println("Connected to the WiFi network");
  Serial.println(WiFi.localIP());

  registerArduino();
}

void loop()
{
  updateAmperage();
  delay(5000);
}