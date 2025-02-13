using PddOpenSdk.Models.Request.Logistics;
using PddOpenSdk.Models.Response.Logistics;
namespace PddOpenSdk.Services.PddApi;
public class LogisticsApi : PddCommonApi
{
    public LogisticsApi() { }
    public LogisticsApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 获取集运DWS设备采集数据
    /// </summary>

    public async Task<GetConsoDwsDataResponse> GetConsoDwsDataAsync(GetConsoDwsData getConsoDwsData)
    {
        var result = await PostAsync<GetConsoDwsData, GetConsoDwsDataResponse>("pdd.conso.dws.data.get", getConsoDwsData);
        return result;
    }

    /// <summary>
    /// 集运图片上传接口
    /// </summary>

    public async Task<UploadConsoImgResponse> UploadConsoImgAsync(UploadConsoImg uploadConsoImg)
    {
        var result = await PostFileAsync<UploadConsoImg, UploadConsoImgResponse>("pdd.conso.img.upload", uploadConsoImg);
        return result;
    }

    /// <summary>
    /// 偏远集运中转仓包裹扫码入库
    /// </summary>

    public async Task<EnterConsoWarehousePackScanResponse> EnterConsoWarehousePackScanAsync(EnterConsoWarehousePackScan enterConsoWarehousePackScan)
    {
        var result = await PostAsync<EnterConsoWarehousePackScan, EnterConsoWarehousePackScanResponse>("pdd.conso.warehouse.pack.scan.enter", enterConsoWarehousePackScan);
        return result;
    }

    /// <summary>
    /// 偏远集运快递拦截结果回调
    /// </summary>

    public async Task<CallbackConsoWaybillInterceptResultResponse> CallbackConsoWaybillInterceptResultAsync(CallbackConsoWaybillInterceptResult callbackConsoWaybillInterceptResult)
    {
        var result = await PostAsync<CallbackConsoWaybillInterceptResult, CallbackConsoWaybillInterceptResultResponse>("pdd.conso.waybill.intercept.result.callback", callbackConsoWaybillInterceptResult);
        return result;
    }

    /// <summary>
    /// 重抛逆向运单回传
    /// </summary>

    public async Task<CallbackHeavygoodsBackExpressResponse> CallbackHeavygoodsBackExpressAsync(CallbackHeavygoodsBackExpress callbackHeavygoodsBackExpress)
    {
        var result = await PostAsync<CallbackHeavygoodsBackExpress, CallbackHeavygoodsBackExpressResponse>("pdd.heavygoods.back.express.callback", callbackHeavygoodsBackExpress);
        return result;
    }

    /// <summary>
    /// 获取拼多多标准地址库
    /// </summary>

    public async Task<GetLogisticsAddressResponse> GetLogisticsAddressAsync(GetLogisticsAddress getLogisticsAddress)
    {
        var result = await PostAsync<GetLogisticsAddress, GetLogisticsAddressResponse>("pdd.logistics.address.get", getLogisticsAddress);
        return result;
    }

    /// <summary>
    /// 获取可发货快递接口
    /// </summary>

    public async Task<RecommendLogisticsAvailableCompanyResponse> RecommendLogisticsAvailableCompanyAsync(RecommendLogisticsAvailableCompany recommendLogisticsAvailableCompany)
    {
        var result = await PostAsync<RecommendLogisticsAvailableCompany, RecommendLogisticsAvailableCompanyResponse>("pdd.logistics.available.company.recommend", recommendLogisticsAvailableCompany);
        return result;
    }

    /// <summary>
    /// 快递公司查看接口
    /// </summary>

    public async Task<GetLogisticsCompaniesResponse> GetLogisticsCompaniesAsync(GetLogisticsCompanies getLogisticsCompanies)
    {
        var result = await PostAsync<GetLogisticsCompanies, GetLogisticsCompaniesResponse>("pdd.logistics.companies.get", getLogisticsCompanies);
        return result;
    }

    /// <summary>
    /// ISV物流轨迹推送消息订阅接口
    /// </summary>

    public async Task<SubLogisticsIsvTraceNotifyResponse> SubLogisticsIsvTraceNotifyAsync(SubLogisticsIsvTraceNotify subLogisticsIsvTraceNotify)
    {
        var result = await PostAsync<SubLogisticsIsvTraceNotify, SubLogisticsIsvTraceNotifyResponse>("pdd.logistics.isv.trace.notify.sub", subLogisticsIsvTraceNotify);
        return result;
    }

    /// <summary>
    /// 订单发货通知接口
    /// </summary>

    public async Task<SendLogisticsOnlineResponse> SendLogisticsOnlineAsync(SendLogisticsOnline sendLogisticsOnline)
    {
        var result = await PostAsync<SendLogisticsOnline, SendLogisticsOnlineResponse>("pdd.logistics.online.send", sendLogisticsOnline);
        return result;
    }

    /// <summary>
    /// 轨迹查询接口
    /// </summary>

    public async Task<GetLogisticsOrdertraceResponse> GetLogisticsOrdertraceAsync(GetLogisticsOrdertrace getLogisticsOrdertrace)
    {
        var result = await PostAsync<GetLogisticsOrdertrace, GetLogisticsOrdertraceResponse>("pdd.logistics.ordertrace.get", getLogisticsOrdertrace);
        return result;
    }

    /// <summary>
    /// 运单号特殊标签查询
    /// </summary>

    public async Task<GetLogisticsSpecialTagResponse> GetLogisticsSpecialTagAsync(GetLogisticsSpecialTag getLogisticsSpecialTag)
    {
        var result = await PostAsync<GetLogisticsSpecialTag, GetLogisticsSpecialTagResponse>("pdd.logistics.special.tag.get", getLogisticsSpecialTag);
        return result;
    }

    /// <summary>
    /// 末端三段轨迹回传
    /// </summary>

    public async Task<SyncTailExpressTraceResponse> SyncTailExpressTraceAsync(SyncTailExpressTrace syncTailExpressTrace)
    {
        var result = await PostAsync<SyncTailExpressTrace, SyncTailExpressTraceResponse>("pdd.tail.express.trace.sync", syncTailExpressTrace);
        return result;
    }

    /// <summary>
    /// 偏远集运快递拦截请求下发
    /// </summary>

    public async Task<ApplyConsoWaybillInterceptResponse> ApplyConsoWaybillInterceptAsync(ApplyConsoWaybillIntercept applyConsoWaybillIntercept)
    {
        var result = await PostAsync<ApplyConsoWaybillIntercept, ApplyConsoWaybillInterceptResponse>("pdd.conso.waybill.intercept.apply", applyConsoWaybillIntercept);
        return result;
    }

    /// <summary>
    /// 香港集运末端代收点同步供应商
    /// </summary>

    public async Task<ProviderInfoSyncExpressResponse> ProviderInfoSyncExpressAsync(ProviderInfoSyncExpress providerInfoSyncExpress)
    {
        var result = await PostAsync<ProviderInfoSyncExpress, ProviderInfoSyncExpressResponse>("site.info.sync.express.provider", providerInfoSyncExpress);
        return result;
    }

}
