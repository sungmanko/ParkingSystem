using System;

namespace ParkingSystem
{
    public class clsUtil
    {
        private int BaseTime = 10;
        private int BasePrice = 300;

        /// <summary>
        /// 駐車料金計算
        /// </summary>
        /// <returns>計算結果金額</returns>
        public string ParkingPrice(string targetData)
        {
            return
                (Math.Ceiling(Convert.ToDouble(targetData) / BaseTime) * BasePrice).ToString();
        }

        /// <summary>
        /// 駐車料金計算
        /// </summary>
        /// <returns>計算結果金額</returns>
        public string ParkingPriceMinus(string targetData)
        {
            return
                (Math.Ceiling(Convert.ToDouble(targetData) / BaseTime) * BasePrice).ToString();
        }
    }
}
