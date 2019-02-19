
#include <gtk/gtk.h>

static void print_hereKitty (GtkWidget *widget, gpointer data)
{
	g_print ( "Here kitty kitty...\n" );
}

static gboolean on_delete_event (GtkWidget *widget, GdkEvent *event, gpointer data)
{
	/* If you return FALSE in the "delete_event" signal handler,
   * GTK will emit the "destroy" signal. Returning TRUE means
   * you don't want the window to be destroyed.
   *
   * This is useful for popping up 'are you sure you want to quit?'
   * type dialogs.
   */
	g_print ("delete event occurred\n");
	return TRUE;
}

int main (int   argc, char *argv[])
{
  GtkWidget *window;
  GtkWidget *button;
  
  gtk_init (&argc, &argv);

  window = gtk_window_new (GTK_WINDOW_TOPLEVEL);
  gtk_window_set_title (GTK_WINDOW (window), "Here kitty kitty...");
  g_signal_connect (window, "delete-event", G_CALLBACK (on_delete_event), NULL);
  g_signal_connect (window, "destroy", G_CALLBACK (gtk_main_quit), NULL);
  //gtk_container_set_border_width (GTK_CONTAINER (window), 100);
  button = gtk_button_new_with_label ("Here kitty kitty...");
  g_signal_connect (button, "clicked", G_CALLBACK (print_hereKitty), NULL);
  g_signal_connect_swapped (button, "clicked", G_CALLBACK (gtk_widget_destroy), window);
  gtk_widget_show (button);
  gtk_widget_show (window);

  gtk_main ();

  return 0;
  
  }
