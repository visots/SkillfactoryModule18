namespace Task18_3_8
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // запрос выгрузки информации с сайта
            string uri = "http://192.250.225.62/";
            string resource = "?965502";

            await LoadSite(uri, resource);
        }

        static async Task LoadSite(string uri, string resource)
        {
            // создаем клиента для http-запросов
            var httpClient = SiteLoader.GetHttpClient(uri);

            // задаем адрес сайта
            httpClient.BaseAddress = new Uri(uri);

            // запрашиваем нужный ресурс
            var result = await httpClient.GetAsync(resource);

            // считываем ответ в строку и выводим
            var contentString = await result.Content.ReadAsStringAsync();
            Console.WriteLine(contentString);
        }
    }
}