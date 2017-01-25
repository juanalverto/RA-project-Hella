using UnityEngine;
using System.Collections;

public class ControlEventos : MonoBehaviour 
{

  public Collider web;
  public Collider mail;
  public Collider face;
  public Collider twit;

	void Start () 
  {
	
	}
	
	void Update () 
  {
    if (Input.GetButtonDown("Fire1"))
    {
       Ray ray  = Camera.main.ScreenPointToRay(Input.mousePosition);
       RaycastHit hit = new RaycastHit();


        if(web.Raycast(ray,out hit,10000f))
         {
           Application.OpenURL("http://wantmake.it");
         }
         else if(mail.Raycast(ray,out hit,10000f))
         {
           string email = "juanalverto@gmail.com";
           string subject = MyEscapeURL("Hola Jay");
           string body = MyEscapeURL("Saludos\r\nEstoy viendo tu trabajo");
           Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
         }
         else if(face.Raycast(ray,out hit,10000f))
         {
           Application.OpenURL("https://www.facebook.com/juanalverto");
         }
         else if(twit.Raycast(ray,out hit,10000f))
         {
           Application.OpenURL("https://twitter.com/MyRadicalTV");
         }
      }
    }


  string MyEscapeURL (string url)
  {
    return WWW.EscapeURL(url).Replace("+","%20");
  }
}
