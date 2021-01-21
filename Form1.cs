using System;
using System.Web;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBountyRecon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " intitle:index.of");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " ext:xml | ext:conf | ext:cnf | ext:reg | ext:inf | ext:rdp | ext:cfg | ext:txt | ext:ora | ext:ini");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " ext:sql | ext:dbf | ext:mdb");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " inurl:wp- | inurl:wp-content | inurl:plugins | inurl:uploads | inurl:themes | inurl:download");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " ext:log");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " ext:bkf | ext:bkp | ext:bak | ext:old | ext:backup");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " inurl:login | inurl:signin | intitle:Login | intitle: signin | inurl:auth");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " ext:doc | ext:docx | ext:odt | ext:pdf | ext:rtf | ext:sxw | ext:psw | ext:ppt | ext:pptx | ext:pps | ext:csv");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " ext:php intitle:phpinfo \"published by the PHP Group\"");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + "  inurl:shell | inurl:backdoor | inurl:wso | inurl:cmd | shadow | passwd | boot.ini | inurl:backdoor");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + "  inurl:readme | inurl:license | inurl:install | inurl:setup | inurl:config");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " intext:\"sql syntax near\" | intext:\"syntax error has occurred\" | intext:\"incorrect syntax near\" | intext:\"unexpected end of SQL command\" | intext:\"Warning: mysql_connect()\" | intext:\"Warning: mysql_query()\" | intext:\"Warning: pg_connect()\"");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " inurl:redir | inurl:url | inurl:redirect | inurl:return | inurl:src=http | inurl:r=http");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " ext:action | ext:struts | ext:do");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastebin.com " + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:linkedin.com employees " + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button37_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=.sharepoint.com/_vti_bin/webpartpages/asmx -docs -msdn -mdsec site:" + HttpUtility.UrlEncode(textBox1.Text));
            toolTip1.Show("PoC CallExternalMethodActivity x: Name = \"foo\"....System.Diagnostics.Process.Start(\"cmd.exe\", \"/c ping BurpCollabServer]\");private/**void**foobar(){//' />", button37);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " filetype:wsdl | filetype:WSDL | ext:svc | inurl:wsdl | Filetype: ?wsdl | inurl:asmx?wsdl | inurl:jws?wsdl | intitle:_vti_bin/sites.asmx?wsdl | inurl:_vti_bin/sites.asmx?wsdl");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            const string quote = "\"";
            const string astrik = "*.";
            System.Diagnostics.Process.Start("https://github.com/search?q=" + quote + astrik + HttpUtility.UrlEncode(textBox1.Text) + quote);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            const string quote = "\"";
            System.Diagnostics.Process.Start("https://gist.github.com/search?q=*." + quote + HttpUtility.UrlEncode(textBox1.Text) + quote);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const string quote = "\"";
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " filetype:config " + quote + "apache"+ quote);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            const string quote = "\"";
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site%3Ahttp%3A%2F%2Fideone.com+|+site%3Ahttp%3A%2F%2Fcodebeautify.org+|+site%3Ahttp%3A%2F%2Fcodeshare.io+|+site%3Ahttp%3A%2F%2Fcodepen.io+|+site%3Ahttp%3A%2F%2Frepl.it+|+site%3Ahttp%3A%2F%2Fjustpaste.it+|+site%3Ahttp%3A%2F%2Fpastebin.com+|+site%3Ahttp%3A%2F%2Fjsfiddle.net+|+site%3Ahttp%3A%2F%2Ftrello.com+|+site%3A*.atlassian.net+|+site%3Abitbucket.org+"  + quote + HttpUtility.UrlEncode(textBox1.Text) + quote);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            const string quote = "\"";
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site%3Aatlassian.net+|+site%3Abitbucket.org+" + quote + HttpUtility.UrlEncode(textBox1.Text) + quote);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            const string quote = "\"";
            System.Diagnostics.Process.Start("https://www.google.com/search?q=inurl:" + quote + "/.git " + quote +  HttpUtility.UrlEncode(textBox1.Text) + " -github ");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            const string quote = "\"";
            System.Diagnostics.Process.Start("https://www.google.com/search?q=intitle:traefik+inurl:8080/dashboard" + quote + HttpUtility.UrlEncode(textBox1.Text) + quote);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://crt.sh/?q=" + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            const string quote = "\"";
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " inurl:" + quote + "/phpinfo.php" + quote + " | inurl:" + quote + ".htaccess" + quote);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            const string astrik = "*.";
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + astrik + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button22_Click(object sender, EventArgs e)
        {
            const string astrik = "*.*.";
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + astrik + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button23_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + HttpUtility.UrlEncode(textBox1.Text) + " inurl:wp-content | inurl:wp-includes");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://wwwb-dedup.us.archive.org:8083/cdx/search?url=" + HttpUtility.UrlEncode(textBox1.Text) + "/&matchType=domain&collapse=digest&output=text&fl=original,timestamp&filter=urlkey:.*wp[-].*&limit=1000000&xx=");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.openbugbounty.org/search/?search=" + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.reddit.com/search/?q=" + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button28_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + HttpUtility.UrlEncode(textBox1.Text) + "/crossdomain.xml");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + HttpUtility.UrlEncode(textBox1.Text) + "/robots.txt");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://securityheaders.com/?q=" + HttpUtility.UrlEncode(textBox1.Text) + "&followRedirects=on");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://threatcrowd.org/domain.php?domain=" + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button49_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://community.riskiq.com/search/" + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=inurl:" + HttpUtility.UrlEncode(textBox1.Text) + " ext:swf");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=" + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button31_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yandex.com/search/?text=site:" + HttpUtility.UrlEncode(textBox1.Text) + "  mime:swf");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.archive.org/cdx/search?url=" + HttpUtility.UrlEncode(textBox1.Text) + "/&matchType=domain&collapse=urlkey&output=text&fl=original&filter=urlkey:.*swf&limit=100000");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.archive.org/cdx/search?url=" + HttpUtility.UrlEncode(textBox1.Text) + "/&matchType=domain&collapse=urlkey&output=text&fl=original&filter=mimetype:application/x-shockwave-flash&limit=100000");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.archive.org/web/*/" + HttpUtility.UrlEncode(textBox1.Text) + "/*");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://viewdns.info/reverseip/?host=" + HttpUtility.UrlEncode(textBox1.Text) + "&t=1");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            const string quote = "\"";
            System.Diagnostics.Process.Start("https://publicwww.com/websites/" + quote + HttpUtility.UrlEncode(textBox1.Text) + quote + "/");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://censys.io/ipv4?q=" + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button41_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://censys.io/domain?q=" + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button40_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://censys.io/certificates?q=" + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button39_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.shodan.io/search?query=" + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button51_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cse.google.com/cse?cx=002972716746423218710:veac6ui3rio#gsc.tab=0&gsc.q=" + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button52_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:throwbin.io " + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button53_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://domaineye.com/similar/" + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button54_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=inurl:gitlab " + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void button55_Click(object sender, EventArgs e)
        {
            const string quote = "\"";
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:stackoverflow.com " + quote + HttpUtility.UrlEncode(textBox1.Text) + quote);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            const string quote = "\"";
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:.s3.amazonaws.com " + quote + HttpUtility.UrlEncode(textBox1.Text) + quote);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            const string quote = "\"";
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:digitaloceanspaces.com " + quote + HttpUtility.UrlEncode(textBox1.Text) + quote);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://whatcms.org/?s=" + HttpUtility.UrlEncode(textBox1.Text));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/ManiarViral/");
        }
    }
}
