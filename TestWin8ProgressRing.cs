using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using W8PR = Win8ProgressRing.Win8_ProgressRing;

namespace TestWin8ProgressRing
    {
    
    // ************************************ class TestWin8ProgressRing
    
    public partial class TestWin8ProgressRing : Form
        {

        // ********************************************* ExtractIconEx
        
        [DllImport("Shell32")]
        public static extern int ExtractIconEx (
                string  sFile,
                int     iIndex,
            out IntPtr  piLargeVersion,
            out IntPtr  piSmallVersion,
                int     amountIcons );
                
        // ***************************************** GetExecutableIcon
        
        Icon GetExecutableIcon ( )
            {
            IntPtr large;
            IntPtr small;
            
            ExtractIconEx (     Application.ExecutablePath, 
                                0, 
                            out large, 
                            out small, 
                                1 );
            return ( Icon.FromHandle ( small ) );
            }

        // *********************************** center_control_in_panel
        
        void center_control_in_panel ( )
            {
            int  x;
            int  y;
            
            x = ( control_PAN.Width - win8_progress_ring.Width ) / 2;
            y = ( control_PAN.Height - win8_progress_ring.Height ) / 2;
            
            win8_progress_ring.Location = new Point ( x, y );
            }
            
        // ************************************** TestWin8ProgressRing
        
        public TestWin8ProgressRing ( )
            {
            string [ ]  pieces;
            
            InitializeComponent ( );

            pieces = win8_progress_ring.ProductVersion.Split ( 
                            new char [ ] { '.' }, 
                            StringSplitOptions.RemoveEmptyEntries );
            this.Text = String.Format (
                            "Test Win8 Progress Ring V{0}.{1}",
                            pieces [ 0 ],
                            pieces [ 1 ] );

            this.Icon = GetExecutableIcon ( );
            
            control_height_NUD.Value = 
                win8_progress_ring.Control_Height;
            center_control_in_panel ( );
            
            refresh_interval_NUD.Value =
                win8_progress_ring.Refresh_Rate;

            animated_RB.Checked = true;
            pulsed_RB.Checked = false;
            
            start_stop_BUT.Enabled = true;
            pulse_BUT.Enabled = false;
            
            if ( start_stop_BUT.Text.Equals ( "Stop" ) )
                {
                win8_progress_ring.Animate = true;
                }
            else
                {
                win8_progress_ring.Animate = false;
                }
            }

        // ******************************** animated_RB_CheckedChanged
        
        private void animated_RB_CheckedChanged ( object    sender, 
                                                  EventArgs e )
            {

            if ( animated_RB.Checked )
                {
                pulse_BUT.Enabled = false;
                
                start_stop_BUT.Enabled = true;
                
                win8_progress_ring.Animate = true;
                }
            else
                {
                pulse_BUT.Enabled = true;

                start_stop_BUT.Enabled = false;

                win8_progress_ring.Animate = false;
                }
            }

        // ************************************** start_stop_but_Click
        
        void start_stop_BUT_Click ( )
            {

            if ( animated_RB.Checked )
                {
                if ( start_stop_BUT.Text.Equals ( "Stop" ) )
                    {
                    win8_progress_ring.Animate = false;
                    start_stop_BUT.Text = "Start";
                    }
                else
                    {
                    win8_progress_ring.Animate = true;
                    start_stop_BUT.Text = "Stop";
                    }
                }
            }

        // ********************************************** color_choice

        Color color_choice ( Color  current_color )
            {
            Color       color = current_color;
            ColorDialog color_dialog;

            try
                {
                color_dialog = new ColorDialog ( );
                color_dialog.AllowFullOpen = true;
                color_dialog.AnyColor = true;
                color_dialog.Color = current_color;
                color_dialog.FullOpen = false;
                color_dialog.ShowHelp = true;
                color_dialog.SolidColorOnly = false;
                
                if ( color_dialog.ShowDialog ( ) == DialogResult.OK )
                    {
                    color = color_dialog.Color;
                    }
                    
                color_dialog.Dispose ( );
                }
            catch
                {
                color = current_color;
                }
            
            return ( color ) ;
            }
            
        // ************************************************* BUT_Click
        
        private void BUT_Click ( object    sender, 
                                 EventArgs e )
            {
            Button  button = ( Button ) sender;
            string  tag = button.Tag.ToString ( ).
                                     ToLower ( ).
                                     Trim ( );
            
            switch ( tag )
                {
                case "exit":
                    Application.Exit ( );
                    break;

                case "indicator_color":
                    {
                    Color  chosen_color = color_choice ( 
                                                button.BackColor );

                    button.BackColor = chosen_color;
                    win8_progress_ring.Indicator_Color = chosen_color;
                    }
                    break;
                    
                case "panel_background_color":
                    {
                    Color  chosen_color = color_choice ( 
                                                button.BackColor );

                    button.BackColor = chosen_color;
                    control_PAN.BackColor = chosen_color;
                    }
                    break;
                    
                case "pulse":
                    if ( pulsed_RB.Checked )
                        {
                        win8_progress_ring.Pulse ( );
                        }
                    break;

                case "start_stop":
                    start_stop_BUT_Click ( );
                    break;

                default:
                
                    break;
                }
            }

        // ****************************************** NUD_ValueChanged
        
        void NUD_ValueChanged ( object    sender, 
                                EventArgs e )
            {
            NumericUpDown nud = ( NumericUpDown ) sender;
            string        tag = nud.Tag.ToString ( ).
                                        ToLower ( ).
                                        Trim ( );
            
            switch ( tag )
                {
                case "control_height":
                    win8_progress_ring.Control_Height = 
                        Convert.ToInt32 ( nud.Value );
                    center_control_in_panel ( );
                    break;
                    
                case "refresh_interval":
                    win8_progress_ring.Refresh_Rate = 
                        Convert.ToInt32 ( nud.Value );
                    break;
                    
                default:
                    
                    break;
                    
                }
            }
            
        } // class TestWin8ProgressRing
        
    } // namespace TestWin8ProgressRing
