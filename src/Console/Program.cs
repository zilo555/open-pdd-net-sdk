using Console.Helpers;

namespace Sample;

internal class Program
{
    private async static Task Main(string[] args)
    {
        var helper = new PddApiDocHelper();
        await helper.Run();
        await helper.GeneratePddServiceClassAsync();

        System.Console.WriteLine("👌 接口生成成功，查看PddOpenSdk项目，按回车退出.");
        System.Console.ReadLine();
    }
}
