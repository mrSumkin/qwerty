using System;
using System.Diagnostics;
using System.IO;

// Token: 0x0200009C RID: 156
public static class cjf
{
	// Token: 0x0600039F RID: 927 RVA: 0x00011258 File Offset: 0x0000F458
	public static void b(string A_0, string A_1)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		DirectoryInfo a_ = new DirectoryInfo(A_0);
		DirectoryInfo a_2 = new DirectoryInfo(A_1);
		cjf.a(a_, a_2);
		stopwatch.Stop();
		Trace.WriteLine("XCopy took: " + stopwatch.Elapsed.ToString());
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x000112A8 File Offset: 0x0000F4A8
	public static void a(string A_0)
	{
		if (Directory.Exists(A_0))
		{
			new DirectoryInfo(A_0).Attributes = FileAttributes.Normal;
			string[] array = Directory.GetDirectories(A_0);
			for (int i = 0; i < array.Length; i++)
			{
				cjf.a(array[i]);
			}
			array = Directory.GetFiles(A_0);
			for (int i = 0; i < array.Length; i++)
			{
				File.SetAttributes(array[i], FileAttributes.Normal);
			}
		}
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00011320 File Offset: 0x0000F520
	private static void a(DirectoryInfo A_0, DirectoryInfo A_1)
	{
		if (!Directory.Exists(A_1.FullName))
		{
			Directory.CreateDirectory(A_1.FullName);
		}
		foreach (FileInfo fileInfo in A_0.GetFiles())
		{
			Console.WriteLine("Copying {0}\\{1}", A_1.FullName, fileInfo.Name);
			fileInfo.CopyTo(Path.Combine(A_1.ToString(), fileInfo.Name), true);
		}
		foreach (DirectoryInfo directoryInfo in A_0.GetDirectories())
		{
			DirectoryInfo a_ = A_1.CreateSubdirectory(directoryInfo.Name);
			cjf.a(directoryInfo, a_);
		}
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x000113D4 File Offset: 0x0000F5D4
	private static void a(string A_0, string A_1)
	{
		byte[] array = dh4.a();
		using (FileStream fileStream = new FileStream(A_0, FileMode.Open, FileAccess.Read, FileShare.None, array.Length))
		{
			using (BinaryReader binaryReader = new BinaryReader(fileStream))
			{
				using (FileStream fileStream2 = new FileStream(A_1, FileMode.Create, FileAccess.Write, FileShare.None, array.Length))
				{
					using (BinaryWriter binaryWriter = new BinaryWriter(fileStream2))
					{
						for (;;)
						{
							int num = binaryReader.Read(array, 0, array.Length);
							if (num == 0)
							{
								break;
							}
							binaryWriter.Write(array, 0, num);
						}
					}
				}
			}
		}
	}
}
