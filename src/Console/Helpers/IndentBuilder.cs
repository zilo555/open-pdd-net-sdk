namespace Console.Helpers;
/// <summary>
/// 缩进内容构造
/// </summary>
public class IndentBuilder
{
    /// <summary>
    /// tab:default is 4 whitesapce
    /// </summary>
    public uint TabSize { get; set; } = 4;

    /// <summary>
    /// 当前缩进数量
    /// </summary>
    public uint CurrentSize { get; private set; }

    private readonly StringBuilder _builder = new();

    public IndentBuilder()
    {
    }

    public IndentBuilder(uint currentSize)
    {
        CurrentSize = currentSize;
    }

    public void AppendLine(string content)
    {
        AppendIndent(content);
    }

    /// <summary>
    /// 缩进插入
    /// </summary>
    /// <param name="content"></param>
    public void IndentLine(string content = "")
    {
        AppendIndent(content, IndentType.Indent);
    }

    /// <summary>
    /// 缩进插入
    /// </summary>
    /// <param name="content"></param>
    public void UnIndentLine(string content = "")
    {
        AppendIndent(content, IndentType.UnIndent);
    }

    public void Reset()
    {
        CurrentSize = 0;
        _builder.Clear();
        _builder.Capacity = 0;
    }

    private void AppendIndent(string content = "", IndentType indent = IndentType.None)
    {
        switch (indent)
        {
            case IndentType.Indent:
                CurrentSize += TabSize;
                break;
            case IndentType.UnIndent:
                if (CurrentSize >= TabSize)
                {
                    CurrentSize -= TabSize;
                }
                break;
            case IndentType.None:
                break;
            default:
                break;
        }

        if (CurrentSize >= 0)
        {
            // 如果包含换行，则对缩进进行处理
            if (content.Contains(Environment.NewLine))
            {
                var lines = content.Split(Environment.NewLine);
                foreach (var line in lines)
                {
                    _builder.Append(new string(' ', (int)CurrentSize));
                    _builder.AppendLine(line);
                }
                return;
            }
            else
            {
                _builder.Append(new string(' ', (int)CurrentSize));
                _builder.AppendLine(content);
            }
        }
    }

    public override string ToString()
    {
        return _builder.ToString();
    }

    public enum IndentType
    {
        None,
        Indent,
        UnIndent
    }
}
