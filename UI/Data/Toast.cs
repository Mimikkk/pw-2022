namespace UI.Data;

public class Toast {
  public string Type { get; } = "success";
  public string Message { get; }
  public bool Visible { get; set; } = true;
  public bool EnterAnimation { get; set; } = true;
  public bool ExitAnimation { get; set; }

  public Toast(string type, string message) {
    Type = type;
    Message = message;
  }
}
