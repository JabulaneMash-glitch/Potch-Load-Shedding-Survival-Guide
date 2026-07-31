using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstOpp2024
{
    public partial class Info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cook = Request.Cookies["info"];
            if (cook != null)
            {
                lblNameOut.Text = "Hi " + cook["name"] + " " + cook["sur"] + "!";
                if(Session["zone"] != null)
                {
                    string zone = (string)Session["zone"];
                    lblZoneOut.Text = "Your current zone is: " + zone;

                    if(zone == "Zone 1(Central Business District)")
                    {
                        if(Calendar1.SelectedDate.DayOfWeek != DayOfWeek.Monday && Calendar1.SelectedDate.DayOfWeek != DayOfWeek.Thursday)
                        {
                            if(Calendar1.SelectedDate == DateTime.Today)
                            {
                                lblDate.Text = "Today's load shedding forecast:";
                                lblTime.Text = "There is load shedding today at the following times\n\n 06:00-08:30, 12:00-14:30";
                            }
                            else if (Calendar1.SelectedDate < DateTime.Today || Calendar1.SelectedDate > DateTime.Today)
                            {
                                //lblDate.ForeColor = System.Drawing.Color.Black;
                                lblDate.Text = Calendar1.SelectedDate.ToString("dddd") + "'s load shedding forecast:";
                                lblTime.Text = "There is load shedding today at the following times\n\n 06:00-08:30, 12:00-14:30";
                            }
                        }
                        else if (Calendar1.SelectedDate.DayOfWeek == DayOfWeek.Monday || Calendar1.SelectedDate.DayOfWeek == DayOfWeek.Thursday)
                        {
                            lblTime.Text = "";
                            //lblDate.ForeColor = System.Drawing.Color.Green;
                            lblDate.Text = "There is no load shedding ;)";
                        }
                    }
                    else if (zone == "Zone 2(Van der Hoff Park)")
                    {
                        if (Calendar1.SelectedDate.DayOfWeek != DayOfWeek.Tuesday && Calendar1.SelectedDate.DayOfWeek != DayOfWeek.Friday)
                        {
                            if (Calendar1.SelectedDate == DateTime.Today)
                            {
                                lblDate.Text = "Today's load shedding forecast:";
                                lblTime.Text = "There is load shedding today at the following times\n\n 09:00-11:30, 15:00-17:30";
                            }
                            else if (Calendar1.SelectedDate < DateTime.Today || Calendar1.SelectedDate > DateTime.Today)
                            {
                                //lblDate.ForeColor = System.Drawing.Color.Black;
                                lblDate.Text = Calendar1.SelectedDate.ToString("dddd") + "'s load shedding forecast:";
                                lblTime.Text = "There is load shedding today at the following times\n\n 09:00-11:30, 15:00-17:30";
                            }
                        }
                        else if (Calendar1.SelectedDate.DayOfWeek == DayOfWeek.Tuesday || Calendar1.SelectedDate.DayOfWeek == DayOfWeek.Friday)
                        {
                            lblTime.Text = "";
                            //lblDate.ForeColor = System.Drawing.Color.Green;
                            lblDate.Text = "There is no load shedding ;)";
                        }
                    }
                    else if (zone == "Zone 3(Bult Area and University Campus)")
                    {
                        if (Calendar1.SelectedDate.DayOfWeek != DayOfWeek.Wednesday && Calendar1.SelectedDate.DayOfWeek != DayOfWeek.Saturday)
                        {
                            if (Calendar1.SelectedDate == DateTime.Today)
                            {
                                lblDate.Text = "Today's load shedding forecast:";
                                lblTime.Text = "There is load shedding today at the following times\n\n 18:00-20:30, 00:00-02:30";
                            }
                            else if (Calendar1.SelectedDate < DateTime.Today || Calendar1.SelectedDate > DateTime.Today)
                            {
                                //lblDate.ForeColor = System.Drawing.Color.Black;
                                lblDate.Text = Calendar1.SelectedDate.ToString("dddd") + "'s load shedding forecast:";
                                lblTime.Text = "There is load shedding today at the following times\n\n 18:00-20:30, 00:00-02:30";
                            }
                        }
                        else if (Calendar1.SelectedDate.DayOfWeek == DayOfWeek.Wednesday || Calendar1.SelectedDate.DayOfWeek == DayOfWeek.Saturday)
                        {
                            lblTime.Text = "";
                            //lblDate.ForeColor = System.Drawing.Color.Green;
                            lblDate.Text = "There is no load shedding ;)";
                        }
                    }
                    else if (zone == "Zone 4(Grimbeek Park and Baillie Park)")
                    {
                        if (Calendar1.SelectedDate.DayOfWeek != DayOfWeek.Sunday && Calendar1.SelectedDate.DayOfWeek != DayOfWeek.Wednesday)
                        {
                            if (Calendar1.SelectedDate == DateTime.Today)
                            {
                                lblDate.Text = "Today's load shedding forecast:";
                                lblTime.Text = "There is load shedding today at the following times\n\n 21:00-23:30, 03:00-05:30";
                            }
                            else if (Calendar1.SelectedDate < DateTime.Today || Calendar1.SelectedDate > DateTime.Today)
                            {
                                //lblDate.ForeColor = System.Drawing.Color.Black;
                                lblDate.Text = Calendar1.SelectedDate.ToString("dddd") + "'s load shedding forecast:";
                                lblTime.Text = "There is load shedding today at the following times\n\n 21:00-23:30, 03:00-05:30";
                            }
                        }
                        else if (Calendar1.SelectedDate.DayOfWeek == DayOfWeek.Sunday || Calendar1.SelectedDate.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            lblTime.Text = "";
                            //lblDate.ForeColor = System.Drawing.Color.Green;
                            lblDate.Text = "There is no load shedding ;)";
                        }
                    }
                    else if (zone == "Zone 5(Mohadin and Promosa)")
                    {
                        if (Calendar1.SelectedDate.DayOfWeek != DayOfWeek.Monday && Calendar1.SelectedDate.DayOfWeek != DayOfWeek.Saturday)
                        {
                            if (Calendar1.SelectedDate == DateTime.Today)
                            {
                                lblDate.Text = "Today's load shedding forecast:";
                                lblTime.Text = "There is load shedding today at the following times\n\n 07:00-09:30, 13:00-15:30";
                            }
                            else if (Calendar1.SelectedDate < DateTime.Today || Calendar1.SelectedDate > DateTime.Today)
                            {
                                //lblDate.ForeColor = System.Drawing.Color.Black;
                                lblDate.Text = Calendar1.SelectedDate.ToString("dddd") + "'s load shedding forecast:";
                                lblTime.Text = "There is load shedding today at the following times\n\n 07:00-09:30, 13:00-15:30";
                            }
                        }
                        else if (Calendar1.SelectedDate.DayOfWeek == DayOfWeek.Monday || Calendar1.SelectedDate.DayOfWeek == DayOfWeek.Saturday)
                        {
                            lblTime.Text = "";
                            //lblDate.ForeColor = System.Drawing.Color.Green;
                            lblDate.Text = "There is no load shedding ;)";
                        }
                    }
                    else if (zone == "Zone 6(Ikageng)")
                    {
                        if (Calendar1.SelectedDate.DayOfWeek != DayOfWeek.Thursday && Calendar1.SelectedDate.DayOfWeek != DayOfWeek.Sunday)
                        {
                            if (Calendar1.SelectedDate == DateTime.Today)
                            {
                                lblDate.Text = "Today's load shedding forecast:";
                                lblTime.Text = "There is load shedding today at the following times\n\n 10:00-12:30, 16:00-18:30";
                            }
                            else if (Calendar1.SelectedDate < DateTime.Today || Calendar1.SelectedDate > DateTime.Today)
                            {
                                //lblDate.ForeColor = System.Drawing.Color.Black;
                                lblDate.Text = Calendar1.SelectedDate.ToString("dddd") + "'s load shedding forecast:";
                                lblTime.Text = "There is load shedding today at the following times\n\n 10:00-12:30, 16:00-18:30";
                            }

                        }
                        else if (Calendar1.SelectedDate.DayOfWeek == DayOfWeek.Thursday || Calendar1.SelectedDate.DayOfWeek == DayOfWeek.Sunday)
                        {
                            lblTime.Text = "";
                            //lblDate.ForeColor = System.Drawing.Color.Green;
                            lblDate.Text = "There is no load shedding ;)";
                        }
                    }

                }
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}