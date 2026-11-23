using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Design;
using Ouroboros.Playfield.Lightning;

// Token: 0x0200023B RID: 571
[TypeConverter(typeof(bf7))]
[eiz("L1")]
[Serializable]
public struct ae8 : ISerializable
{
	// Token: 0x06001023 RID: 4131 RVA: 0x00042FCC File Offset: 0x000411CC
	public Color d()
	{
		return this.a;
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x00042FD4 File Offset: 0x000411D4
	public void a(Color A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x00042FE0 File Offset: 0x000411E0
	public float c()
	{
		return this.b;
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x00042FE8 File Offset: 0x000411E8
	public void a(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x00042FF4 File Offset: 0x000411F4
	public LightType a()
	{
		return this.c;
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x00042FFC File Offset: 0x000411FC
	public void a(LightType A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x00043008 File Offset: 0x00041208
	public static bool b(ae8 A_0, ae8 A_1)
	{
		return A_0.Equals(A_1);
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x00043020 File Offset: 0x00041220
	public static bool a(ae8 A_0, ae8 A_1)
	{
		return !A_0.Equals(A_1);
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x00043038 File Offset: 0x00041238
	public ae8(Color A_0, float A_1, LightType A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x00043050 File Offset: 0x00041250
	public Color b()
	{
		return new Color((int)((byte)((float)this.d().R * this.c())), (int)((byte)((float)this.d().G * this.c())), (int)((byte)((float)this.d().B * this.c())));
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x000430A8 File Offset: 0x000412A8
	public override bool Equals(object obj)
	{
		if (!(obj is ae8))
		{
			return false;
		}
		ae8 ae = (ae8)obj;
		return this.a == ae.a && this.b == ae.b && this.c == ae.c;
	}

	// Token: 0x0600102E RID: 4142 RVA: 0x00043100 File Offset: 0x00041300
	public override int GetHashCode()
	{
		return this.a.GetHashCode() + this.b.GetHashCode() + this.c.GetHashCode();
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x00043134 File Offset: 0x00041334
	public override string ToString()
	{
		ColorConverter colorConverter = new ColorConverter();
		return string.Concat(new string[]
		{
			colorConverter.ConvertToString(this.a),
			"; ",
			this.b.ToString(),
			"; ",
			this.c.ToString()
		});
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x00043198 File Offset: 0x00041398
	public static ae8 a(string A_0)
	{
		string[] array = A_0.Split(new char[]
		{
			';'
		});
		ae8 result = default(ae8);
		if (array.Length != 0)
		{
			try
			{
				ColorConverter colorConverter = new ColorConverter();
				result.a((Color)colorConverter.ConvertFromString(array[0]));
			}
			catch
			{
			}
		}
		if (array.Length > 1)
		{
			try
			{
				result.a(float.Parse(array[1], CultureInfo.InvariantCulture));
			}
			catch
			{
			}
		}
		if (array.Length > 2)
		{
			try
			{
				result.a((LightType)Enum.Parse(typeof(LightType), array[2]));
			}
			catch
			{
			}
		}
		return result;
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x0004327C File Offset: 0x0004147C
	private ae8(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() >= 6)
		{
			this.a = (Color)A_0.GetValue("C", typeof(Color));
			this.b = A_0.GetSingle("I");
			this.c = (LightType)A_0.GetValue("T", typeof(LightType));
			return;
		}
		this.a = (Color)A_0.GetValue("_Color", typeof(Color));
		this.b = A_0.GetSingle("_Intensity");
		this.c = (LightType)A_0.GetValue("_Type", typeof(LightType));
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x00043338 File Offset: 0x00041538
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("C", this.a);
		info.AddValue("I", this.b);
		info.AddValue("T", this.c);
	}

	// Token: 0x0400096B RID: 2411
	private Color a;

	// Token: 0x0400096C RID: 2412
	private float b;

	// Token: 0x0400096D RID: 2413
	private LightType c;
}
