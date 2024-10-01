
#nullable enable

namespace Groq
{
    /// <summary>
    /// The format of the transcript output, in one of these options: `json`, `text`, or `verbose_json`.<br/>
    /// Default Value: json
    /// </summary>
    public enum CreateTranscriptionRequestResponseFormat
    {
        /// <summary>
        /// `json`, `text`, or `verbose_json`.
        /// </summary>
        Json,
        /// <summary>
        /// `json`, `text`, or `verbose_json`.
        /// </summary>
        Text,
        /// <summary>
        /// `json`, `text`, or `verbose_json`.
        /// </summary>
        VerboseJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranscriptionRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranscriptionRequestResponseFormat value)
        {
            return value switch
            {
                CreateTranscriptionRequestResponseFormat.Json => "json",
                CreateTranscriptionRequestResponseFormat.Text => "text",
                CreateTranscriptionRequestResponseFormat.VerboseJson => "verbose_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranscriptionRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => CreateTranscriptionRequestResponseFormat.Json,
                "text" => CreateTranscriptionRequestResponseFormat.Text,
                "verbose_json" => CreateTranscriptionRequestResponseFormat.VerboseJson,
                _ => null,
            };
        }
    }
}