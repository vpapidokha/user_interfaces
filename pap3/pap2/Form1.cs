using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pap2
{
	public partial class Form1 : Form
	{
		#region Declaration

		bool isCoocieCracked = false;
		string[] wishes =
		{
			"Make a wish, it would happens!",
			"Have a nice day!",
			"aloha!!",
			"i love u!",
			"Heeeey, have a nice day!"
		};
		Random rand = new Random();
		SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
		GrammarBuilder gBuilder = new GrammarBuilder();
		bool isVoiceControlEnabled;
		SpeechSynthesizer voice = new SpeechSynthesizer();


		#endregion

		#region Methods: Public

		public Form1()
		{
			InitializeComponent();
		}

		#endregion

		#region Methods: Private

		private void Form1_Load(object sender, EventArgs e)
		{
			Choices commands = new Choices();
			commands.Add(new string[] { "go", "more" });
			gBuilder.Append(commands);
			Grammar grammar = new Grammar(gBuilder);

			recEngine.LoadGrammar(grammar);
			recEngine.SetInputToDefaultAudioDevice();
			recEngine.SpeechRecognized += recEngine_SpeechRecognized;
			recEngine.RecognizeAsync(RecognizeMode.Multiple);
		}

		private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
		{
			switch (e.Result.Text)
			{
				case "go":
					CrackCookie();
					break;
				case "more":
					CreateNewCookie();
					break;
				default:
					break;
			}
		}

		private void cookie_lbl_Click(object sender, EventArgs e)
		{

		}

		private void crack_button_Click(object sender, EventArgs e)
		{
			if (isCoocieCracked)
			{
				CreateNewCookie();
			}
			else
			{
				CrackCookie();
			}
		}

		protected virtual void CrackCookie()
		{
			if (isCoocieCracked)
			{
				voice.Speak("Cookie is already cracked! Ask for one more");
			}
			else
			{
				crack_button.Text = "Add one more Cookie!";
				cookie_lbl.Image = Properties.Resources.post;
				text_lbl.Text = wishes[rand.Next(0, wishes.Length)];
				text_lbl.Visible = true;
				isCoocieCracked = true;
				voice.Speak(text_lbl.Text);
			}
		}

		protected virtual void CreateNewCookie()
		{
			text_lbl.Visible = false;
			crack_button.Text = "Crack Cookie!";
			cookie_lbl.Image = Properties.Resources.pre;
			isCoocieCracked = false;
		}

		#endregion

	}
}
