namespace PddOpenSdk.Models.Response.Virtual;
public partial class QueryVirtualGameServerResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("game_server_query_response")]
    public GameServerQueryResponseResponse GameServerQueryResponse { get; set; }

    public partial class GameServerQueryResponseResponse
    {

        /// <summary>
        /// 游戏CODE
        /// </summary>
        [JsonPropertyName("goods_config_code")]
        public string GoodsConfigCode { get; set; }

        /// <summary>
        /// 游戏ID
        /// </summary>
        [JsonPropertyName("goods_config_id")]
        public long? GoodsConfigId { get; set; }

        /// <summary>
        /// 游戏配置名称
        /// </summary>
        [JsonPropertyName("goods_config_name")]
        public string GoodsConfigName { get; set; }

        /// <summary>
        /// 区服信息
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<ItemListResponse> ItemList { get; set; }

        public partial class ItemListResponse
        {

            /// <summary>
            /// 下级区服信息
            /// </summary>
            [JsonPropertyName("children")]
            public List<ChildrenResponse> Children { get; set; }

            /// <summary>
            /// 区服ID
            /// </summary>
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; }

            /// <summary>
            /// 类型 1-区 2-服
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

            public partial class ChildrenResponse
            {

                /// <summary>
                /// 区服ID
                /// </summary>
                [JsonPropertyName("id")]
                public long? Id { get; set; }

                /// <summary>
                /// 名称
                /// </summary>
                [JsonPropertyName("name")]
                public string Name { get; set; }

                /// <summary>
                /// 类型 1-区 2-服
                /// </summary>
                [JsonPropertyName("type")]
                public int? Type { get; set; }


            }

        }

    }

}

