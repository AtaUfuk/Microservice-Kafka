namespace Microservice_Kafka.Common.Utilities
{
    public static class StaticValues
    {
        #region Sonuc Mesajlari
        /// <summary>
        /// Başarılı işlem genel mesajıdır.
        /// </summary>
        public static readonly string SuccessMessage = "İşleminiz başarılı bir şekilde gerçekleşmiştir.";
        /// <summary>
        /// Hatalı işlem genel mesajıdır.
        /// </summary>
        public static readonly string ErrorMessage = "İşleminiz esnasında bir sorun ile karşılaşıldı, lütfen daha sonra tekrardan deneyiniz.";
        /// <summary>
        /// 404 hata mesajıdır
        /// </summary>
        public static readonly string ErrorNotFoundMesssage = "Aradığınız metod bulunamamıştır.";
        /// <summary>
        /// 500 hata mesajıdır
        /// </summary>
        public static readonly string ErrorServerMessage = "Sunucu kaynaklı bir hata ile karşılaşıldı, lütfen daha sonra tekrardan deneyiniz";
        #endregion
        #region Sonuc Kodlari
        /// <summary>
        /// Başarılı işlem genel kodu.
        /// </summary>
        public static readonly int SuccessCode = 200;
        /// <summary>
        /// Hatalı işlem genel kodu.
        /// </summary>
        public static readonly int ErrorCode = 100;
        /// <summary>
        /// 404 hata kodu
        /// </summary>
        public static readonly int ErrorNotFoundCode = 404;
        /// <summary>
        /// 500 hata kodu
        /// </summary>
        public static readonly int ErrorServerCode = 500;
        #endregion
    }
}
