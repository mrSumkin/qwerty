using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

// Token: 0x020000E9 RID: 233
[TypeConverter(typeof(bf7))]
[eiz("DR1")]
[Serializable]
public struct b1j : ISerializable
{
	// Token: 0x0600052A RID: 1322 RVA: 0x00017038 File Offset: 0x00015238
	public double b()
	{
		return (this.b + this.c) / 2.0;
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x00017054 File Offset: 0x00015254
	public static bool b(b1j A_0, b1j A_1)
	{
		return A_0.Equals(A_1);
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0001706C File Offset: 0x0001526C
	public static bool a(b1j A_0, b1j A_1)
	{
		return A_0.Equals(A_1);
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x00017084 File Offset: 0x00015284
	public b1j(double A_0, double A_1)
	{
		this.b = A_0;
		this.c = A_1;
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x00017098 File Offset: 0x00015298
	public double b(Random A_0, double A_1)
	{
		double num = A_0.NextDouble();
		double num2 = this.b + (this.c - this.b) * num;
		if (A_1 > 0.0)
		{
			return (double)Convert.ToInt32(num2 / A_1) * A_1;
		}
		return num2;
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x000170E0 File Offset: 0x000152E0
	public void a(double A_0, bool A_1)
	{
		this.a(b1j.a, A_0, A_1);
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x000170F4 File Offset: 0x000152F4
	public void a(Random A_0, double A_1, bool A_2)
	{
		double num = b1j.a(A_0, A_1);
		this.b *= 1.0 + num;
		if (!A_2)
		{
			num = b1j.a(A_0, A_1);
		}
		this.c *= 1.0 + num;
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x00017148 File Offset: 0x00015348
	public double a()
	{
		return this.b(b1j.a, 0.0);
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00017160 File Offset: 0x00015360
	public override string ToString()
	{
		return string.Format("{0}-{1}", this.b, this.c);
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x00017184 File Offset: 0x00015384
	public string b(string A_0)
	{
		return string.Format("{0}-{1}", this.b.ToString(A_0), this.c.ToString(A_0));
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x000171AC File Offset: 0x000153AC
	public override bool Equals(object obj)
	{
		if (obj is b1j)
		{
			b1j b1j = (b1j)obj;
			return this.c == b1j.c && this.b == b1j.b;
		}
		return false;
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x000171F0 File Offset: 0x000153F0
	public override int GetHashCode()
	{
		return this.c.GetHashCode() + this.b.GetHashCode();
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0001720C File Offset: 0x0001540C
	public static b1j a(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			string[] array = A_0.Split(new string[]
			{
				"-"
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length == 2)
			{
				double a_;
				double.TryParse(array[0], NumberStyles.Number, CultureInfo.InvariantCulture, out a_);
				double a_2;
				double.TryParse(array[1], NumberStyles.Number, CultureInfo.InvariantCulture, out a_2);
				return new b1j(a_, a_2);
			}
		}
		return default(b1j);
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x00017280 File Offset: 0x00015480
	private static double a(Random A_0, double A_1)
	{
		return A_0.NextDouble() * A_1 * (double)((A_0.Next(0, 1) == 1) ? 1 : -1);
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x000172AC File Offset: 0x000154AC
	private b1j(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() >= 6)
		{
			this.b = A_0.GetDouble("MI");
			this.c = A_0.GetDouble("MX");
			return;
		}
		this.b = A_0.GetDouble("Min");
		this.c = A_0.GetDouble("Max");
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x0001730C File Offset: 0x0001550C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("MI", this.b);
		info.AddValue("MX", this.c);
	}

	// Token: 0x0400047D RID: 1149
	private static Random a = new Random();

	// Token: 0x0400047E RID: 1150
	public double b;

	// Token: 0x0400047F RID: 1151
	public double c;
}
