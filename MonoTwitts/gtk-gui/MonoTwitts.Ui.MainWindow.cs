// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoTwitts.Ui {
    
    
    public partial class MainWindow {
        
        private Gtk.Action MenuAction;
        
        private Gtk.Action HelpAction;
        
        private Gtk.Action AboutAction;
        
        private Gtk.VBox vbox1;
        
        private Gtk.MenuBar menubar1;
        
        private Gtk.Toolbar toolbar1;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoTwitts.Ui.MainWindow
            Gtk.UIManager w1 = new Gtk.UIManager();
            Gtk.ActionGroup w2 = new Gtk.ActionGroup("Default");
            this.MenuAction = new Gtk.Action("MenuAction", Mono.Unix.Catalog.GetString("Menu"), null, null);
            this.MenuAction.ShortLabel = Mono.Unix.Catalog.GetString("Menu");
            w2.Add(this.MenuAction, "<Control>m");
            this.HelpAction = new Gtk.Action("HelpAction", Mono.Unix.Catalog.GetString("Help"), null, null);
            this.HelpAction.ShortLabel = Mono.Unix.Catalog.GetString("Help");
            w2.Add(this.HelpAction, "<Control>h");
            this.AboutAction = new Gtk.Action("AboutAction", Mono.Unix.Catalog.GetString("About"), null, "gtk-about");
            this.AboutAction.ShortLabel = Mono.Unix.Catalog.GetString("About");
            w2.Add(this.AboutAction, null);
            w1.InsertActionGroup(w2, 0);
            this.AddAccelGroup(w1.AccelGroup);
            this.Name = "MonoTwitts.Ui.MainWindow";
            this.Title = Mono.Unix.Catalog.GetString("MainWindow");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Container child MonoTwitts.Ui.MainWindow.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            w1.AddUiFromString("<ui><menubar name='menubar1'><menu action='MenuAction'/><menu action='HelpAction'><menuitem action='AboutAction'/></menu></menubar></ui>");
            this.menubar1 = ((Gtk.MenuBar)(w1.GetWidget("/menubar1")));
            this.menubar1.Name = "menubar1";
            this.vbox1.Add(this.menubar1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            w1.AddUiFromString("<ui><toolbar name='toolbar1'/></ui>");
            this.toolbar1 = ((Gtk.Toolbar)(w1.GetWidget("/toolbar1")));
            this.toolbar1.Name = "toolbar1";
            this.toolbar1.ShowArrow = false;
            this.toolbar1.ToolbarStyle = ((Gtk.ToolbarStyle)(0));
            this.vbox1.Add(this.toolbar1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox1[this.toolbar1]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 400;
            this.DefaultHeight = 300;
            this.Show();
            this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
            this.AboutAction.Activated += new System.EventHandler(this.OnAboutActionActivated);
        }
    }
}
