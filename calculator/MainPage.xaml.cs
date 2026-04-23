#region Region A
using calculator.Resourcen.en;
#endregion
#region Region B
#if MACCATALYST
#elif IOS
#elif Tizen
#elif ANDROID
#elif WINDOWS
//Window window = new Window
//{
//  TitleBar = new TitleBar
//  {
//    Title = "calculator",
//    Content = new SearchBar { }
//  }
//};

#endif
#endregion
#region Region C
namespace calculator
{
  public partial class MainPage : ContentPage
  {
    #region ≡≡≡≡
    #region A-01
    // Classes

    #endregion
    #region A-02
    // Controlls
    private Label FA_ = new();
    //static Grid xxxx = [];
    //static Editor yyyy = new();
    #endregion
    #region A-11
    // Allgemein
    static byte AAA, AAB;
    #endregion
    #region A-12
    #endregion
    #region A-13
    #endregion
    #region A-14
    #endregion
    #region A-15
    #endregion
    #endregion
    #region ○○○○
    #region A_00
    public MainPage()
    {
      InitializeComponent();
      try
      {
        //B101.IsSpellCheckEnabled = false; B103.IsSpellCheckEnabled = false;

        C101.Text = "1"; C102.Text = "2"; C103.Text = "3"; C104.Text = "4"; C105.Text = "5";
        C106.Text = "6"; C107.Text = "7"; C108.Text = "8"; C109.Text = "9"; C110.Text = "0";
        C111.Text = "e"; C112.Text = "π"; C113.Text = "["; C114.Text = "ǀ"; C115.Text = "|";
        C116.Text = "]"; C117.Text = "+"; C118.Text = "*"; C119.Text = "^"; C120.Text = "∞";
        C121.Text = "–"; C122.Text = ";"; C123.Text = "√"; C124.Text = "Δ"; C125.Text = "-";
        C127.Text = "´"; C128.Text = "°"; C129.Text = "("; C130.Text = ")"; C131.Text = "!";
        C132.Text = "→"; C133.Text = "θ"; C134.Text = "Ʃ"; C135.Text = "∏"; C136.Text = "ʃ";
        C137.Text = "ϕ"; C138.Text = "ln"; C139.Text = "lim"; C140.Text = "log";
        C141.Text = "cos"; C142.Text = "sin"; C143.Text = "tan"; C144.Text = "cot";
        C145.Text = "acos"; C146.Text = "asin"; C147.Text = "atan"; C148.Text = "acot";

        C149.Text = ""; C150.Text = "˄"; C151.Text = ""; C152.Text = "⛭"; C153.Text = "<";
        C154.Text = "⬜"; C155.Text = ">"; C156.Text = "⛯"; C157.Text = ""; C158.Text = "˅";
        C159.Text = ""; C160.Text = ""; C161.Text = ""; C162.Text = ""; C163.Text = "";
        C164.Text = ""; A109.Text = "A1"; A110.Text = "B1";

        if (Preferences.Get("upgrade", "defaultValue") == "18.02.2022")
        {
          //  B103.FontFamily = New FontFamily("Segoe UI")
          //ABAD(5) : ABAE(Colors.White, Colors.Lime, A_D.GetString("E001") & vbCrLf)
          //ABAD(5) : ABAE(Colors.White, Colors.Black, A_E.GetString("A002"))
        }

        C126.Text = Source_aa.A254; //B101.Text = Source_aa.A201; B103.Text = Source_aa.A202;

        for (int i = 1; i < 5; i += 1) { AA00.RowDefinitions.Add(new RowDefinition()); }
        for (int i = 1; i < 11; i += 1) { A100.ColumnDefinitions.Add(new ColumnDefinition()); }
        for (int i = 1; i < 4; i += 1) { B100.RowDefinitions.Add(new RowDefinition()); }
        for (int i = 1; i < 3; i += 1) { B100.ColumnDefinitions.Add(new ColumnDefinition()); }
        for (int i = 1; i < 5; i += 1) { C100.RowDefinitions.Add(new RowDefinition()); }
        for (int i = 1; i < 20; i += 1) { C100.ColumnDefinitions.Add(new ColumnDefinition()); }

        Grid.SetRow(A100, 0); Grid.SetRow(B100, 1); Grid.SetRow(B200, 1); Grid.SetRow(B300, 1);
        Grid.SetRow(B400, 1); Grid.SetRow(C100, 3);
        Grid.SetColumn(A101, 0); Grid.SetColumn(A102, 1); Grid.SetColumn(A103, 2); Grid.SetColumn(A104, 3);
        Grid.SetColumn(A105, 4); Grid.SetColumn(A106, 5); Grid.SetColumn(A107, 6); Grid.SetColumn(A108, 7);
        Grid.SetColumn(A109, 8); Grid.SetColumn(A110, 9);
        Grid.SetRow(B101, 0); Grid.SetColumn(B101, 0); Grid.SetRow(B102, 0); Grid.SetColumn(B102, 1);
        //Grid.SetRow(B103, 2); Grid.SetColumn(B103, 0); Grid.SetRow(B104, 2); Grid.SetColumn(B104, 0);
        //Grid.SetRow(B105, 2); Grid.SetColumn(B105, 1);
        Grid.SetRow(C101, 0); Grid.SetColumn(C101, 0); Grid.SetRow(C102, 0); Grid.SetColumn(C102, 1);
        Grid.SetRow(C103, 0); Grid.SetColumn(C103, 2); Grid.SetRow(C104, 0); Grid.SetColumn(C104, 3);
        Grid.SetRow(C105, 1); Grid.SetColumn(C105, 0); Grid.SetRow(C106, 1); Grid.SetColumn(C106, 1);
        Grid.SetRow(C107, 1); Grid.SetColumn(C107, 2); Grid.SetRow(C108, 1); Grid.SetColumn(C108, 3);
        Grid.SetRow(C109, 2); Grid.SetColumn(C109, 0); Grid.SetRow(C110, 2); Grid.SetColumn(C110, 1);
        Grid.SetRow(C111, 2); Grid.SetColumn(C111, 2); Grid.SetRow(C112, 2); Grid.SetColumn(C112, 3);
        Grid.SetRow(C113, 3); Grid.SetColumn(C113, 0); Grid.SetRow(C114, 3); Grid.SetColumn(C114, 1);
        Grid.SetRow(C115, 3); Grid.SetColumn(C115, 2); Grid.SetRow(C116, 3); Grid.SetColumn(C116, 3);
        Grid.SetRow(C117, 0); Grid.SetColumn(C117, 5); Grid.SetRow(C118, 0); Grid.SetColumn(C118, 6);
        Grid.SetRow(C119, 0); Grid.SetColumn(C119, 7); Grid.SetRow(C120, 0); Grid.SetColumn(C120, 8);
        Grid.SetRow(C121, 1); Grid.SetColumn(C121, 5); Grid.SetRow(C122, 1); Grid.SetColumn(C122, 6);
        Grid.SetRow(C123, 1); Grid.SetColumn(C123, 7); Grid.SetRow(C124, 1); Grid.SetColumn(C124, 8);
        Grid.SetRow(C125, 2); Grid.SetColumn(C125, 5); Grid.SetRow(C126, 2); Grid.SetColumn(C126, 6);
        Grid.SetRow(C127, 2); Grid.SetColumn(C127, 7); Grid.SetRow(C128, 2); Grid.SetColumn(C128, 8);
        Grid.SetRow(C129, 3); Grid.SetColumn(C129, 5); Grid.SetRow(C130, 3); Grid.SetColumn(C130, 6);
        Grid.SetRow(C131, 3); Grid.SetColumn(C131, 7); Grid.SetRow(C132, 3); Grid.SetColumn(C132, 8);
        Grid.SetRow(C133, 0); Grid.SetColumn(C133, 10); Grid.SetRow(C134, 0); Grid.SetColumn(C134, 11);
        Grid.SetRow(C135, 0); Grid.SetColumn(C135, 12); Grid.SetRow(C136, 0); Grid.SetColumn(C136, 13);
        Grid.SetRow(C137, 1); Grid.SetColumn(C137, 10); Grid.SetRow(C138, 1); Grid.SetColumn(C138, 11);
        Grid.SetRow(C139, 1); Grid.SetColumn(C139, 12); Grid.SetRow(C140, 1); Grid.SetColumn(C140, 13);
        Grid.SetRow(C141, 2); Grid.SetColumn(C141, 10); Grid.SetRow(C142, 2); Grid.SetColumn(C142, 11);
        Grid.SetRow(C143, 2); Grid.SetColumn(C143, 12); Grid.SetRow(C144, 2); Grid.SetColumn(C144, 13);
        Grid.SetRow(C145, 3); Grid.SetColumn(C145, 10); Grid.SetRow(C146, 3); Grid.SetColumn(C146, 11);
        Grid.SetRow(C147, 3); Grid.SetColumn(C147, 12); Grid.SetRow(C148, 3); Grid.SetColumn(C148, 13);
        Grid.SetRow(C149, 0); Grid.SetColumn(C149, 15); Grid.SetRow(C150, 0); Grid.SetColumn(C150, 16);
        Grid.SetRow(C151, 0); Grid.SetColumn(C151, 17); Grid.SetRow(C152, 0); Grid.SetColumn(C152, 18);
        Grid.SetRow(C153, 1); Grid.SetColumn(C153, 15); Grid.SetRow(C154, 1); Grid.SetColumn(C154, 16);
        Grid.SetRow(C155, 1); Grid.SetColumn(C155, 17); Grid.SetRow(C156, 1); Grid.SetColumn(C156, 18);
        Grid.SetRow(C157, 2); Grid.SetColumn(C157, 15); Grid.SetRow(C158, 2); Grid.SetColumn(C158, 16);
        Grid.SetRow(C159, 2); Grid.SetColumn(C159, 17); Grid.SetRow(C160, 2); Grid.SetColumn(C160, 18);
        Grid.SetRow(C161, 3); Grid.SetColumn(C161, 15); Grid.SetRow(C162, 3); Grid.SetColumn(C162, 16);
        Grid.SetRow(C163, 3); Grid.SetColumn(C163, 17); Grid.SetRow(C164, 3); Grid.SetColumn(C164, 18);

        ToolTipProperties.SetText(A101, Source_aa.A001); ToolTipProperties.SetText(A102, Source_aa.A002);
        ToolTipProperties.SetText(A103, Source_aa.A003); ToolTipProperties.SetText(A104, Source_aa.A004);
        ToolTipProperties.SetText(A105, Source_aa.A005); ToolTipProperties.SetText(A106, Source_aa.A006);
        ToolTipProperties.SetText(A107, Source_aa.A007); ToolTipProperties.SetText(A108, Source_aa.A008);

        //xxxx = this.FindByName<Grid>("AA00");
        //yyyy = this.FindByName<Editor>("B103");

        //B101.Focused += (o, e) => { };
        //B103.Focused += (o, e) => { };
        //B104.Focused += (o, e) => { };
        AAA = 1;
        AAA0.Loaded += (o, e) => { A_A_(); };
        AAA0.SizeChanged += (o, e) => A_B_();
      }
      catch (Exception ex) { FA_.Text = ex.Message; }
    }
    #endregion
    #region A_10
    public void A_A_()
    {
      AAA = 1; AAB = 1; A_B_();
    }
    public void A_B_()
    {
      if (B100.ColumnDefinitions.Count == 2)
      {
        if (AAA0.Width > 1.5 * AAA0.Height)
        { if (AAA != 1) { AAA = 1; } AAAA(); }
        else
        { if (AAA != 2) { AAA = 2; } AAAA(); }
      }
    }
    #endregion
    #region Թ_10
    private void Թ_A_(object sender, EventArgs e)
    {

    }
    private void Թ_B_(object sender, EventArgs e)
    {

    }
    #endregion
    #region A100
    public void A_AA(object sender, EventArgs e)
    {

    }
    public void A_AB(object sender, EventArgs e)
    {

    }
    public void A_AC(object sender, EventArgs e)
    {

    }
    public void A_AD(object sender, EventArgs e)
    {

    }
    public void A_AE(object sender, EventArgs e)
    {

    }
    public void A_AF(object sender, EventArgs e)
    {

    }
    public void A_AG(object sender, EventArgs e)
    {

    }
    public void A_AH(object sender, EventArgs e)
    {

    }
    public void A_AI(object sender, EventArgs e)
    {

    }
    public void A_AJ(object sender, EventArgs e)
    {

    }
    public void A_AK(object sender, EventArgs e)
    {

    }
    public void A_AL(object sender, EventArgs e)
    {

    }
    #endregion
    #region B100
    private void B_ՀA(object a, TappedEventArgs b)
    {

    }
    private void B_ՀB()
    {

    }
    private void B_ϞA()
    {

    }
    private void B_ΔA()
    {

    }
    private void B_ΞA()
    {

    }
    private void B_ΔB()
    {

    }
    #endregion
    #region B200
    public void B_BA(object sender, EventArgs e)
    {

    }
    public void B_BB(object sender, EventArgs e)
    {

    }
    public void B_BC(object sender, EventArgs e)
    {

    }
    public void B_BD(object sender, EventArgs e)
    {

    }
    public void B_BE(object sender, EventArgs e)
    {

    }
    public void B_BF(object sender, EventArgs e)
    {

    }
    public void B_BG(object sender, EventArgs e)
    {

    }
    public void B_BH(object sender, EventArgs e)
    {

    }
    public void B_BI(object sender, EventArgs e)
    {

    }
    public void B_BJ(object sender, EventArgs e)
    {

    }
    #endregion
    #region C100
    public void C_AA(object sender, EventArgs e)
    {

    }
    public void C_AB(object sender, EventArgs e)
    {

    }
    public void C_AC(object sender, EventArgs e)
    {

    }
    public void C_AD(object sender, EventArgs e)
    {

    }
    public void C_AE(object sender, EventArgs e)
    {

    }
    public void C_AF(object sender, EventArgs e)
    {

    }
    public void C_AG(object sender, EventArgs e)
    {

    }
    public void C_AH(object sender, EventArgs e)
    {

    }
    #endregion
    #region Թ100
    private void Թ_AA(object a, EventArgs b)
    {

    }
    private void Թ_AB()
    {

    }
    #endregion
    #endregion
    #region □□□□
    #region AAAA
    #region A-AA
    public void AAAA()
    {
      switch (AAA * 100 + AAB)
      {
        case 101:

          B100.IsVisible = true; B200.IsVisible = false; B300.IsVisible = false;
          B400.IsVisible = false; C100.IsVisible = true;

          AA00.RowDefinitions[0].Height = new GridLength(1, GridUnitType.Star);
          AA00.RowDefinitions[1].Height = new GridLength(12, GridUnitType.Star);
          AA00.RowDefinitions[2].Height = new GridLength(1, GridUnitType.Star);
          AA00.RowDefinitions[3].Height = new GridLength(6, GridUnitType.Star);

          for (int i = 0; i < 64; i += 1)
          {
            ACAD(C100.Children[i]).Background = Colors.Blue;
            ACAD(C100.Children[i]).TextColor = Colors.White;
          }
          for (int i = 0; i < 10; i += 1)
          {
            ACAD(A100.Children[i]).Background = Colors.Blue;
            ACAD(A100.Children[i]).TextColor = Colors.White;
          }

          break;
        case 102:

          break;
        case 103:

          break;
        case 104:

          break;
        case 105:

          break;
        case 106:

          break;
        case 201:

          break;
        case 202:

          break;
        case 203:

          break;
        case 204:

          break;
        case 205:

          break;
        case 206:

          break;
      }
    }
    static void AABA()
    {

    }
    static void AABB()
    {

    }
    static void AABC()
    {

    }
    static void AABE()
    {

    }
    static void AABG()
    {

    }
    static void AACA()
    {

    }
    static void AACB()
    {

    }
    static void AACC()
    {

    }
    static void AACE()
    {

    }
    static void AACG()
    {

    }
    static void AADA()
    {

    }
    static void AADB()
    {

    }
    static void AADC()
    {

    }
    static void AADD()
    {

    }
    static void AAEA()
    {

    }
    static void AAEB()
    {

    }
    static void AAFA()
    {

    }
    static void AAFB()
    {

    }
    static void AAFC()
    {

    }
    static void AAGA()
    {

    }
    static void AAGB()
    {

    }
    #endregion
    #region A-AB
    static void ABAA()
    {

    }
    static void ABAB()
    {

    }
    static void ABAC()
    {

    }
    static void ABAD()
    {

    }
    static void ABAE()
    {

    }
    static void ABAF()
    {

    }
    static void ABBA()
    {

    }
    static void ABBB()
    {

    }
    static void ABBC()
    {

    }
    #endregion
    #region A-AC

    static Button ACAD(IView a)
    {
      return (Button)a;
    }

    #endregion
    #region A-AD

    #endregion
    #region A-AE

    #endregion
    #endregion
    #region BBBB
    #endregion
    #region CCCC
    public void CABD(object sender, EventArgs e)
    {

    }
    #endregion
    #region DDDD
    #endregion
    #region EEEE
    #endregion
    #endregion
  }
}
#endregion

