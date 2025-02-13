namespace PddOpenSdk.Models.Response.Ktt;
public partial class SpecKttGoodsCreateResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse? Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// 规格map
        /// </summary>
        [JsonPropertyName("spec_map")]
        public Dictionary<string, object>? SpecMap { get; set; }

        /// <summary>
        /// 请求结果
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        public partial class SpecMapResponse
        {

            /// <summary>
            /// 父规格名
            /// </summary>
            [JsonPropertyName("$key")]
            public string? Key { get; set; }

            /// <summary>
            /// 子规格列表
            /// </summary>
            [JsonPropertyName("$value")]
            public List<ValueResponse?>? Value { get; set; }

            public partial class ValueResponse
            {

                /// <summary>
                /// 子规格名
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 父规格名
                /// </summary>
                [JsonPropertyName("parent_name")]
                public string? ParentName { get; set; }

                /// <summary>
                /// 规格id，创建商品用
                /// </summary>
                [JsonPropertyName("spec_id")]
                public long? SpecId { get; set; }


            }

        }

    }

}

