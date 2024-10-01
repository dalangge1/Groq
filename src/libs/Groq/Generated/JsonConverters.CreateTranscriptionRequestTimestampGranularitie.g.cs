#nullable enable

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTranscriptionRequestTimestampGranularitieJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.CreateTranscriptionRequestTimestampGranularitie>
    {
        /// <inheritdoc />
        public override global::Groq.CreateTranscriptionRequestTimestampGranularitie Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Groq.CreateTranscriptionRequestTimestampGranularitieExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Groq.CreateTranscriptionRequestTimestampGranularitie)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.CreateTranscriptionRequestTimestampGranularitie value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Groq.CreateTranscriptionRequestTimestampGranularitieExtensions.ToValueString(value));
        }
    }
}
