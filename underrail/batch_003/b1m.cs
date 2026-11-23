using System;
using System.Runtime.Serialization;

// Token: 0x0200144A RID: 5194
[eiz("OECAA")]
[Serializable]
public sealed class b1m : b1z, ISerializable
{
	// Token: 0x060074C4 RID: 29892 RVA: 0x003181A4 File Offset: 0x003163A4
	private b1m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("OECAA:E", typeof(ar7)) as ar7);
		this.c = A_0.GetSingle("OECAA:MIV");
		this.d = A_0.GetSingle("OECAA:MXV");
		this.e = A_0.GetInt32("OECAA:CD");
		this.f = A_0.GetDouble("OECAA:CPM");
		this.g = A_0.GetDouble("OECAA:C");
		this.h = A_0.GetInt32("OECAA:I");
		this.i = A_0.GetSingle("OECAA:S");
	}

	// Token: 0x060074C5 RID: 29893 RVA: 0x0031826C File Offset: 0x0031646C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OECAA:E", this.b);
		info.AddValue("OECAA:MIV", this.c);
		info.AddValue("OECAA:MXV", this.d);
		info.AddValue("OECAA:CD", this.e);
		info.AddValue("OECAA:CPM", this.f);
		info.AddValue("OECAA:C", this.g);
		info.AddValue("OECAA:I", this.h);
		info.AddValue("OECAA:S", this.i);
	}

	// Token: 0x060074C6 RID: 29894 RVA: 0x0031830C File Offset: 0x0031650C
	public b1m(c5x A_0, float A_1, float A_2, float A_3, int A_4, double A_5, int A_6)
	{
		this.b = new ar7(A_0);
		this.c = A_1;
		this.d = A_2;
		this.i = A_3;
		this.f = A_5;
		this.h = A_6;
		this.e = A_4;
	}

	// Token: 0x060074C7 RID: 29895 RVA: 0x00318374 File Offset: 0x00316574
	protected override dc4 dt()
	{
		if (this.b == null || this.b.ao() == null)
		{
			return dc4.e;
		}
		cd0[] array = this.a(this.b.ao() as c5x);
		for (int i = 0; i < array.Length; i++)
		{
			array[i].d = new float?(this.i);
		}
		return dc4.b;
	}

	// Token: 0x060074C8 RID: 29896 RVA: 0x003183E0 File Offset: 0x003165E0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.b == null || this.b.ao() == null)
		{
			return dc4.e;
		}
		if ((this.g += A_1.TotalMilliseconds) >= 50.0)
		{
			double num = this.g * this.f * (double)this.e;
			foreach (cd0 cd in this.a(this.b.ao() as c5x))
			{
				cd.d += (float)num;
				if (this.e == 1)
				{
					float? num2 = cd.d;
					float num3 = this.d;
					if (num2.GetValueOrDefault() >= num3 & num2 != null)
					{
						cd.d = new float?(this.d);
						this.e = -1;
					}
				}
				else
				{
					float? num2 = cd.d;
					float num3 = this.c;
					if (num2.GetValueOrDefault() <= num3 & num2 != null)
					{
						cd.d = new float?(this.c);
						this.e = 1;
					}
				}
			}
			this.g -= (0.9 + cuo.a.NextDouble() * 0.2) * 50.0;
		}
		return dc4.b;
	}

	// Token: 0x060074C9 RID: 29897 RVA: 0x00318588 File Offset: 0x00316788
	private cd0[] a(c5x A_0)
	{
		if (A_0.p.b != null)
		{
			if (this.h < 0)
			{
				return A_0.p.b.a.ToArray();
			}
			if (this.h < A_0.p.b.a.Count)
			{
				return new cd0[]
				{
					A_0.p.b.a[this.h]
				};
			}
		}
		else if (A_0.o.b != null)
		{
			return new cd0[]
			{
				A_0.o.b
			};
		}
		return new cd0[0];
	}

	// Token: 0x04002FB5 RID: 12213
	private new const int a = 50;

	// Token: 0x04002FB6 RID: 12214
	private ar7 b;

	// Token: 0x04002FB7 RID: 12215
	private float c;

	// Token: 0x04002FB8 RID: 12216
	private float d = 1f;

	// Token: 0x04002FB9 RID: 12217
	private int e = 1;

	// Token: 0x04002FBA RID: 12218
	private double f;

	// Token: 0x04002FBB RID: 12219
	private double g;

	// Token: 0x04002FBC RID: 12220
	private int h = -1;

	// Token: 0x04002FBD RID: 12221
	private float i;
}
