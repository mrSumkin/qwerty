using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020000F0 RID: 240
[TypeConverter(typeof(bf7))]
[eiz("S")]
[Serializable]
public struct esj : ISerializable
{
	// Token: 0x0600057A RID: 1402 RVA: 0x00017EB8 File Offset: 0x000160B8
	public esj(int A_0, int A_1)
	{
		this = default(esj);
		this.c = A_0;
		this.d = A_1;
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00017ED0 File Offset: 0x000160D0
	public override bool Equals(object obj)
	{
		if (!(obj is esj))
		{
			return false;
		}
		esj esj = (esj)obj;
		return this.c == esj.c && this.d == esj.d;
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00017F18 File Offset: 0x00016118
	public override int GetHashCode()
	{
		return new Vector2((float)this.c, (float)this.d).GetHashCode();
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00017F48 File Offset: 0x00016148
	public override string ToString()
	{
		return this.c.ToString() + ", " + this.d.ToString();
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00017F6C File Offset: 0x0001616C
	public static bool d(esj A_0, esj A_1)
	{
		return A_0.Equals(A_1);
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00017F84 File Offset: 0x00016184
	public static bool c(esj A_0, esj A_1)
	{
		return !A_0.Equals(A_1);
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x00017F9C File Offset: 0x0001619C
	public static esj b(esj A_0, esj A_1)
	{
		return new esj(A_0.c - A_1.c, A_0.d - A_1.d);
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x00017FC0 File Offset: 0x000161C0
	public static esj a(esj A_0, esj A_1)
	{
		return new esj(A_0.c + A_1.c, A_0.d + A_1.d);
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x00017FE4 File Offset: 0x000161E4
	public static esj b(esj A_0, double A_1)
	{
		return new esj((int)((double)A_0.c * A_1), (int)((double)A_0.d * A_1));
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x00018000 File Offset: 0x00016200
	public static esj a(esj A_0, double A_1)
	{
		return new esj((int)((double)A_0.c / A_1), (int)((double)A_0.d / A_1));
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x0001801C File Offset: 0x0001621C
	public static esj a()
	{
		return esj.b;
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00018024 File Offset: 0x00016224
	public esj c()
	{
		return new esj((this.c < 0) ? 0 : this.c, (this.d < 0) ? 0 : this.d);
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x0001805C File Offset: 0x0001625C
	public static esj a(Vector2 A_0)
	{
		return new esj((int)A_0.X, (int)A_0.Y);
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x00018074 File Offset: 0x00016274
	public static esj a(string A_0)
	{
		string[] array = A_0.Split(new char[]
		{
			','
		});
		if (array != null && array.Length == 2)
		{
			try
			{
				int a_ = int.Parse(array[0], CultureInfo.InvariantCulture);
				int a_2 = int.Parse(array[1], CultureInfo.InvariantCulture);
				return new esj(a_, a_2);
			}
			catch
			{
				return esj.a();
			}
		}
		return esj.a();
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x000180F8 File Offset: 0x000162F8
	public Vector2 b()
	{
		return new Vector2((float)this.c, (float)this.d);
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x00018110 File Offset: 0x00016310
	private esj(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() >= 6)
		{
			this.c = A_0.GetInt32("W");
			this.d = A_0.GetInt32("H");
			return;
		}
		this.c = A_0.GetInt32("_Width");
		this.d = A_0.GetInt32("_Height");
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x00018170 File Offset: 0x00016370
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("W", this.c);
		info.AddValue("H", this.d);
	}

	// Token: 0x04000493 RID: 1171
	private const double a = 2.856167851;

	// Token: 0x04000494 RID: 1172
	private static readonly esj b = new esj(0, 0);

	// Token: 0x04000495 RID: 1173
	public int c;

	// Token: 0x04000496 RID: 1174
	public int d;
}
