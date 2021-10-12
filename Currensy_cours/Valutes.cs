using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Currensy_cours
{
    // Класс, содержащий в себе данные о всех валютах
   public class Valutes
    {
        // Массив, содержащий в себе информацию по каждой из валют
        public List<Valute> valuteList = new List<Valute>();

        // Вложенный класс, содержащий в себе данные о конкретной валюте
        public class Valute
        {
            public string ID;
            public string NumCode;
            public string CharCode;
            public double Nominal;
            public string Name;
            public double Value;
            public double Previous;

            // Конструктор класса Valute, который принимает в себя данные по конкретной валюте
            public Valute(string ID, string NumCode, string CharCode, double Nominal, string Name, double Value, double Previous)
            {
                this.ID = ID;
                this.NumCode = NumCode;
                this.CharCode = CharCode;
                this.Nominal = Nominal;
                this.Name = Name;
                this.Value = Value;
                this.Previous = Previous;
            }

        }

        // Конструктор по умолчанию класса Valutes
        public Valutes()
        {
            using (var webClient = new WebClient())
            {
                string rawJSON = Encoding.UTF8.GetString(webClient.DownloadData("https://www.cbr-xml-daily.ru/daily_json.js"));
                //string rawJSON = webClient.DownloadString("https://www.cbr-xml-daily.ru/daily_json.js");  // Скачивание json-файла и преобразование его в строку
                dynamic valutes = JsonConvert.DeserializeObject(rawJSON);                                 // Десериализация json-файла из строки

                // Вынесение каждой из валют в отдельный объект
                dynamic AUD = valutes.Valute.AUD;
                initValute(AUD);

                dynamic AZN = valutes.Valute.AZN;
                initValute(AZN);

                dynamic GBP = valutes.Valute.GBP;
                initValute(GBP);

                dynamic AMD = valutes.Valute.AMD;
                initValute(AMD);

                dynamic BYN = valutes.Valute.BYN;
                initValute(BYN);

                dynamic BGN = valutes.Valute.BGN;
                initValute(BGN);

                dynamic BRL = valutes.Valute.BRL;
                initValute(BRL);

                dynamic HUF = valutes.Valute.HUF;
                initValute(HUF);

                dynamic HKD = valutes.Valute.HKD;
                initValute(HKD);

                dynamic DKK = valutes.Valute.DKK;
                initValute(DKK);

                dynamic USD = valutes.Valute.USD;
                initValute(USD);

                dynamic EUR = valutes.Valute.EUR;
                initValute(EUR);

                dynamic INR = valutes.Valute.INR;
                initValute(INR);

                dynamic KZT = valutes.Valute.KZT;
                initValute(KZT);

                dynamic CAD = valutes.Valute.CAD;
                initValute(CAD);

                dynamic KGS = valutes.Valute.KGS;
                initValute(KGS);

                dynamic CNY = valutes.Valute.CNY;
                initValute(CNY);

                dynamic MDL = valutes.Valute.MDL;
                initValute(MDL);

                dynamic NOK = valutes.Valute.NOK;
                initValute(NOK);

                dynamic PLN = valutes.Valute.PLN;
                initValute(PLN);

                dynamic RON = valutes.Valute.RON;
                initValute(RON);

                dynamic XDR = valutes.Valute.XDR;
                initValute(XDR);

                dynamic SGD = valutes.Valute.SGD;
                initValute(SGD);

                dynamic TJS = valutes.Valute.TJS;
                initValute(TJS);

                dynamic TRY = valutes.Valute.TRY;
                initValute(TRY);

                dynamic TMT = valutes.Valute.TMT;
                initValute(TMT);

                dynamic UZS = valutes.Valute.UZS;
                initValute(UZS);

                dynamic UAH = valutes.Valute.UAH;
                initValute(UAH);

                dynamic CZK = valutes.Valute.CZK;
                initValute(CZK);

                dynamic SEK = valutes.Valute.SEK;
                initValute(SEK);

                dynamic CHF = valutes.Valute.CHF;
                initValute(CHF);

                dynamic ZAR = valutes.Valute.ZAR;
                initValute(ZAR);

                dynamic KRW = valutes.Valute.KRW;
                initValute(KRW);

                dynamic JPY = valutes.Valute.JPY;
                initValute(JPY);

                Valute rub = new Valute("0", "000", "RUB", 1, "Российский рубль", 1, 1);
                valuteList.Add(rub);
            }
        }

        // Функция, в которой происходит инициализация каждой из валют
        void initValute(dynamic obj)
        {
            string id = obj.ID;
            string numCode = obj.NumCode;
            string charCode = obj.CharCode;
            double nominal = obj.Nominal;
            string name = obj.Name;
            double value = obj.Value;
            double previous = obj.Previous;
            Valute tmp = new Valute(id, numCode, charCode, nominal, name, value, previous);
            valuteList.Add(tmp);
        }
    }
}
