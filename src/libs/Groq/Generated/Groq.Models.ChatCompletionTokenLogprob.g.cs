
#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionTokenLogprob
    {
        /// <summary>
        /// A list of integers representing the UTF-8 bytes representation of the token. Useful in instances where characters are represented by multiple tokens and their byte representations must be combined to generate the correct text representation. Can be `null` if there is no bytes representation for the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int>? Bytes { get; set; }

        /// <summary>
        /// The log probability of this token, if it is within the top 20 most likely tokens. Otherwise, the value `-9999.0` is used to signify that the token is very unlikely.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Logprob { get; set; }

        /// <summary>
        /// The token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// List of the most likely tokens and their log probability, at this token position. In rare cases, there may be fewer than the number of requested `top_logprobs` returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Groq.ChatCompletionTokenLogprobTopLogprob> TopLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}