using System;
using System.Runtime.Serialization;

// Token: 0x020004FA RID: 1274
[eiz("MNLA")]
[Serializable]
public sealed class e2y : esc, ISerializable
{
	// Token: 0x060020F1 RID: 8433 RVA: 0x000B0DD0 File Offset: 0x000AEFD0
	private e2y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("MNLA:M");
		this.b = A_0.GetString("MNLA:NN");
		if (ell.a() >= 103)
		{
			this.c = A_0.GetBoolean("MNLA:G");
			this.d = A_0.GetBoolean("MNLA:S");
			return;
		}
		this.c = !A_0.GetBoolean("MNLA:L");
	}

	// Token: 0x060020F2 RID: 8434 RVA: 0x000B0E4C File Offset: 0x000AF04C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MNLA:M", this.a);
		info.AddValue("MNLA:NN", this.b);
		info.AddValue("MNLA:G", this.c);
		info.AddValue("MNLA:S", this.d);
	}

	// Token: 0x060020F3 RID: 8435 RVA: 0x000B0EA8 File Offset: 0x000AF0A8
	public float d()
	{
		return this.a;
	}

	// Token: 0x060020F4 RID: 8436 RVA: 0x000B0EB0 File Offset: 0x000AF0B0
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060020F5 RID: 8437 RVA: 0x000B0EBC File Offset: 0x000AF0BC
	public string c()
	{
		return this.b;
	}

	// Token: 0x060020F6 RID: 8438 RVA: 0x000B0EC4 File Offset: 0x000AF0C4
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060020F7 RID: 8439 RVA: 0x000B0ED0 File Offset: 0x000AF0D0
	public bool b()
	{
		return this.c;
	}

	// Token: 0x060020F8 RID: 8440 RVA: 0x000B0ED8 File Offset: 0x000AF0D8
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060020F9 RID: 8441 RVA: 0x000B0EE4 File Offset: 0x000AF0E4
	public bool a()
	{
		return this.d;
	}

	// Token: 0x060020FA RID: 8442 RVA: 0x000B0EEC File Offset: 0x000AF0EC
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060020FB RID: 8443 RVA: 0x000B0EF8 File Offset: 0x000AF0F8
	public override int d5(bq8 A_0, bq8 A_1)
	{
		if (this.a != 0f)
		{
			string name = bp5.j(this.b);
			float num = A_0.GetPrimitivePropertyValue<float>(name, new float?(0f)).Value;
			if (this.a > 0f)
			{
				float num2 = Math.Max(0f, Math.Min(1f - num, this.a));
				num += num2;
				if (this.a - num2 > 0f)
				{
					float num3 = (this.a - num2) / 2f;
					num += num3;
				}
				if (this.d)
				{
					if (this.c)
					{
						if (num < 1f)
						{
							num = 1f;
						}
					}
					else if (num < 0f)
					{
						num = 0f;
					}
				}
			}
			else
			{
				num += this.a;
				if (this.d)
				{
					if (this.c)
					{
						if (num > -1f)
						{
							num = -1f;
						}
					}
					else if (num > 0f)
					{
						num = 0f;
					}
				}
			}
			num = d05.b(-2f, num, 2f);
			A_0.SetPropertyValue(name, num);
		}
		return 1;
	}

	// Token: 0x060020FC RID: 8444 RVA: 0x000B103C File Offset: 0x000AF23C
	public e2y()
	{
	}

	// Token: 0x04001435 RID: 5173
	private float a;

	// Token: 0x04001436 RID: 5174
	private string b;

	// Token: 0x04001437 RID: 5175
	private bool c;

	// Token: 0x04001438 RID: 5176
	private bool d;
}
