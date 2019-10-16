namespace CloudConnectionLib
{
    /// <summary>
    /// Ugly workaround that I'm not proud of and want to change soon.
    /// </summary>

    public static class OnlineState
    {
        //This should be enum instead of string
        //Also ConnectionLife sounds really bad, make it just `State`
        //Either State.Disconnected or State.Connected, that's all.
        public static string ConnectionLife = "Disconnected";
    }
}
