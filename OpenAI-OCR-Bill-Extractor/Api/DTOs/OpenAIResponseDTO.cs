namespace Api.DTOs;

public class OpenAIResponseDTO
{
    public IEnumerable<ChoiceResponseDTO> choices { get; set; }

    public class ChoiceResponseDTO
    {
        public string text { get; set; }

    }
}