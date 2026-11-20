using System;
using System.IO;

// Token: 0x020000EA RID: 234
public sealed class ecg
{
	// Token: 0x0600053B RID: 1339 RVA: 0x00017340 File Offset: 0x00015540
	public static ecg a(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return null;
		}
		if (File.Exists(A_0))
		{
			try
			{
				FileStream fileStream = File.OpenRead(A_0);
				try
				{
					return ecg.a(fileStream);
				}
				finally
				{
					fileStream.Close();
					fileStream.Dispose();
					fileStream = null;
				}
			}
			catch
			{
			}
		}
		return new ecg
		{
			a = true
		};
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x000173B8 File Offset: 0x000155B8
	public static ecg a(Stream A_0)
	{
		BinaryReader binaryReader = new BinaryReader(A_0);
		ecg ecg = new ecg();
		ecg.c = binaryReader.ReadInt32();
		ecg.d = binaryReader.ReadInt32();
		ecg.e = binaryReader.ReadInt32();
		int count = (int)Math.Ceiling((double)((float)(ecg.d * ecg.e) / 8f));
		ecg.b = binaryReader.ReadBytes(count);
		return ecg;
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x00017420 File Offset: 0x00015620
	public bool a(int A_0, int A_1)
	{
		int num = A_0 / this.c;
		int num2 = A_1 / this.c * this.d + num;
		int num3 = num2 / 8;
		int num4 = num2 % 8;
		byte[] array = this.b;
		int num5 = num3;
		byte b = 128;
		b = (byte)(b >> num4);
		return (array[num5] & b) > 0;
	}

	// Token: 0x04000480 RID: 1152
	public bool a;

	// Token: 0x04000481 RID: 1153
	public byte[] b;

	// Token: 0x04000482 RID: 1154
	public int c = 8;

	// Token: 0x04000483 RID: 1155
	public int d;

	// Token: 0x04000484 RID: 1156
	public int e;
}
