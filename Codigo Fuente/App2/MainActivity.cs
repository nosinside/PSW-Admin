using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ClaveAdministrador
{
    [Activity(Label = "Calculador de Claves BCH", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        public void Alerta(string titulo, string mensaje)
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle(titulo);
            alert.SetMessage(mensaje);
            alert.SetPositiveButton("OK", (senderAlert, args) =>
            {
                
            });

            //run the alert in UI thread to display in the screen
            
                alert.Show();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Creamos los recursos y los agregamos a un evento
            Button procesar = FindViewById<Button>(Resource.Id.btnProcesar);
            TextView macProcesada = FindViewById<TextView>(Resource.Id.lblMacProcesada);
            TextView macaProcesar = FindViewById<TextView>(Resource.Id.txtMacAprocesar);


            // Codigo

            procesar.Click += delegate { 
                String maCalcular;
                maCalcular = " " +  macaProcesar.Text;
                if (maCalcular.Length == 0 || maCalcular.Length > 14 || maCalcular.Length < 13)
                {
                    Alerta("Error", "Mac Incorrecta");
                }
                else
                {
                    if (maCalcular.Length == 13) { 
                    char uno, dos, tres, cuatro, cinco, ceis, siete, ocho, nueve, diez, once, doce;
                    char [] caracteresMac = maCalcular.ToCharArray();
                    char[] caracteresModificados = new char[14];
                    for (int i = 0; i < caracteresMac.Length ; i++)
                    {
                        
                        if (i == 1)
                        {
                            uno = caracteresMac[i];
                            if (uno.Equals('9') || uno.Equals('8'))
                            {
                                caracteresModificados[13] = uno;
                            }
                            else
                            {
                                uno++;
                                uno++;
                                caracteresModificados[13] = uno;
                            }
                        }
                        if (i == 2)
                        {
                            dos = caracteresMac[i];
                            if (dos.Equals('9') || dos.Equals('8'))
                            {
                                caracteresModificados[12] = dos;
                            }
                            else
                            {
                                dos++;
                                dos++;
                                caracteresModificados[12] = dos;
                            }
                        }
                        if (i == 3)
                        {
                            tres = caracteresMac[i];
                            if (tres.Equals('9') || tres.Equals('8'))
                            {
                                caracteresModificados[11] = tres;
                            }
                            else
                            {
                                tres++;
                                tres++;
                                caracteresModificados[11] = tres;
                            }
                        }
                        if (i == 4)
                        {
                            cuatro = caracteresMac[i];
                            if (cuatro.Equals('9') || cuatro.Equals('8'))
                            {
                                caracteresModificados[10] = cuatro;
                                caracteresModificados[9] = '4';
                            }
                            else
                            {
                                cuatro++;
                                cuatro++;
                                caracteresModificados[10] = cuatro;
                                caracteresModificados[9] = '4';
                            }
                        }
                        if (i == 5)
                        {
                            cinco = caracteresMac[i];
                            if (cinco.Equals('9') || cinco.Equals('8'))
                            {
                                caracteresModificados[8] = cinco;
                            }
                            else
                            {
                                cinco++;
                                cinco++;
                                caracteresModificados[8] = cinco;
                            }
                        }
                        if (i == 6)
                        {
                            ceis = caracteresMac[i];
                            if (ceis.Equals('9') || ceis.Equals('8'))
                            {
                                caracteresModificados[7] = ceis;
                            }
                            else
                            {
                               ceis++;
                               ceis++;
                               caracteresModificados[7] = ceis;
                            }
                        }
                        if (i == 7)
                        {
                            siete = caracteresMac[i];
                            if (siete.Equals('9') || siete.Equals('8'))
                            {
                                caracteresModificados[6] = siete;
                            }
                            else
                            {
                                siete++;
                                siete++;
                                caracteresModificados[6] = siete;
                            }
                        }
                        if (i == 8)
                        {
                            ocho = caracteresMac[i];
                            if (ocho.Equals('9') || ocho.Equals('8'))
                            {
                                caracteresModificados[5] = ocho;
                                caracteresModificados[4] = 'E';
                            }
                            else
                            {
                                ocho++;
                                ocho++;
                                caracteresModificados[5] = ocho;
                                caracteresModificados[4] = 'E';
                            }
                        }
                        if (i == 9)
                        {
                            nueve = caracteresMac[i];
                            if (nueve.Equals('9') || nueve.Equals('8'))
                            {
                                caracteresModificados[3] = nueve;
                            }
                            else
                            {
                                nueve++;
                                nueve++;
                                caracteresModificados[3] = nueve;
                            }
                        }
                        if (i == 10)
                        {
                            diez = caracteresMac[i];
                            if (diez.Equals('9') || diez.Equals('8'))
                            {
                                caracteresModificados[2] = diez;
                            }
                            else
                            {
                                diez++;
                                diez++;
                                caracteresModificados[2] = diez;
                            }
                        }
                        if (i == 11)
                        {
                            once = caracteresMac[i];
                            if (once.Equals('9') || once.Equals('8'))
                            {
                                caracteresModificados[1] = once;
                            }
                            else
                            {
                                once++;
                                once++;
                                caracteresModificados[1] = once;
                            }
                        }
                        if (i == 12)
                        {
                            doce = caracteresMac[i];
                            if (doce.Equals('9') || doce.Equals('8'))
                            {
                                caracteresModificados[0] = doce;
                            }
                            else
                            {
                                doce++;
                                doce++;
                                caracteresModificados[0] = doce;
                            }
                        }
                    }

                    String texto = new String(caracteresModificados);
                    macProcesada.Text = texto;
                    }

                    
                }
                
            };
        }

    }
}

