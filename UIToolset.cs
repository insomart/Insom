using System;
using System.IO;
using System.Windows.Forms;
namespace Insomiris
{
	
	public class UIToolset
	{
		//Error detection
		public static string ShowError(Exception ex)
		{
			string error = ex.Message;
			return error;
		}

		public static Stream LoadImage(OpenFileDialog openFileDialog)
		{
			try
			{
				DialogResult dResult = openFileDialog.ShowDialog();
				return openFileDialog.OpenFile();
			}
			catch(IOException ex)
			{
				UIToolset.ShowError(ex);
				return Stream.Null;
			}
		}

		public static Stream LoadImage(string file)
		{
			try
			{
				return new FileStream(file,FileMode.Open);
			}
			catch(IOException ex)
			{
				UIToolset.ShowError(ex);
				return Stream.Null;
			}
		}

		public static ImageSequence LoadSequence(OpenFileDialog openFileDialog)
		{
			try
			{
				DialogResult dResult = openFileDialog.ShowDialog();
				return new ImageSequence(openFileDialog.FileName);
			}
			catch(IOException ex)
			{
				UIToolset.ShowError(ex);
				return null;
			}
		}

		public static void SaveImage(Stream stream, System.Drawing.Image im)
		{
			try
			{
				im.Save(stream,System.Drawing.Imaging.ImageFormat.Jpeg);
				stream.Close();
			}
			catch(IOException ex)
			{
				UIToolset.ShowError(ex);
			}
		}

		public static void SaveImage(SaveFileDialog saveFileDialog, System.Drawing.Image im)
		{
			try
			{
				saveFileDialog.AddExtension = true;
				saveFileDialog.DefaultExt = "jpg";
				DialogResult dResult = saveFileDialog.ShowDialog();
				Stream stream = saveFileDialog.OpenFile();
				im.Save(stream,System.Drawing.Imaging.ImageFormat.Jpeg);
				stream.Close();
			}
			catch(IOException ex)
			{
				UIToolset.ShowError(ex);
			}
		}
	}

	public class UIVars
	{
		private string fileName;

		public string FileName
		{
			get
			{
				return fileName;
			}
			set
			{
				this.fileName = value;
			}
		}
	}

	public class ImageSequence
	{
		private string fileName = string.Empty, fileExtension = string.Empty;

		int startDigit, currentDigit, nSize;

		public ImageSequence(String fileName)
		{
			string[] fileNames = fileName.Split('.');
			int end = fileNames.Length;
			if(fileNames.Length>1)
			{
				fileExtension = fileNames[fileNames.Length-1];
				end = fileNames.Length-1;
			}
			for(int i=0;i<end;i++)
			{
				this.fileName = this.fileName + fileNames[i];
			}

			ExtractName(this.fileName);
		}

		private void ExtractName(string fileName)
		{
			string fName = string.Empty,fDigit = string.Empty;
			for(int i=0;i<fileName.Length;i++)
			{
				if(char.IsDigit(fileName[i]))
				{
					fDigit+=fileName[i];
				}
				else
				{
					fName+=fileName[i];
				}
			}
			try
			{
				startDigit = int.Parse(fDigit);
				nSize = fDigit.Length;
			}
			catch
			{
				startDigit = 0;
			}

			this.fileName = fName;

			currentDigit = startDigit;
			
		}

		public string NextFile
		{
			get
			{
				string digitPortion = currentDigit + "";
				while(digitPortion.Length < nSize)
				{
					digitPortion = "0"+digitPortion;
				}
				string nextFile = fileName + digitPortion;
				if(fileExtension!=null)
				{
					nextFile+= "." + fileExtension; 
				}
				currentDigit++;
				return nextFile;
			}
		}

		public string CurrentCovertedFile
		{
			get
			{
				string digitPortion = (currentDigit-1) + "";
				while(digitPortion.Length < nSize)
				{
					digitPortion = "0"+digitPortion;
				}
				string nextFile = fileName + "_conv" + digitPortion;
				if(fileExtension!=null)
				{
					nextFile+= "." + fileExtension; 
				}
				return nextFile;
			}
		}

	}
}
