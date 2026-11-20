using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200144E RID: 5198
[eiz("PBOF")]
[Serializable]
public sealed class c6y : b1z, ISerializable
{
	// Token: 0x060074D7 RID: 29911 RVA: 0x00318CC8 File Offset: 0x00316EC8
	private c6y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (EntityAspectReference<ka, ka>)A_0.GetValue("SBOF:T", typeof(EntityAspectReference<ka, ka>));
		this.b = A_0.GetInt32("PBOF:P");
		this.c = A_0.GetInt32("PBOF:C");
		this.d = A_0.GetInt32("PBOF.PS");
		this.g = (A_0.GetValue("PBOF:CR", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.h = A_0.GetDouble("PBOF:PCH");
		this.i = A_0.GetInt32("PBOF:CD");
		this.e = A_0.GetInt32("PBOF:SP");
		this.f = A_0.GetInt32("PBOF:EP");
	}

	// Token: 0x060074D8 RID: 29912 RVA: 0x00318D9C File Offset: 0x00316F9C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SBOF:T", this.a);
		info.AddValue("PBOF:P", this.b);
		info.AddValue("PBOF:C", this.c);
		info.AddValue("PBOF.PS", this.d);
		info.AddValue("PBOF:CR", this.g);
		info.AddValue("PBOF:PCH", this.h);
		info.AddValue("PBOF:CD", this.i);
		info.AddValue("PBOF:SP", this.e);
		info.AddValue("PBOF:EP", this.f);
	}

	// Token: 0x060074D9 RID: 29913 RVA: 0x00318E4C File Offset: 0x0031704C
	public object b()
	{
		return null;
	}

	// Token: 0x060074DA RID: 29914 RVA: 0x00318E50 File Offset: 0x00317050
	private ka a()
	{
		if (this.a != null)
		{
			return this.a.ao();
		}
		return null;
	}

	// Token: 0x060074DB RID: 29915 RVA: 0x00318E6C File Offset: 0x0031706C
	public c6y(ka A_0, int A_1, int A_2, int A_3, int A_4 = 1)
	{
		this.a = new EntityAspectReference<ka, ka>(A_0);
		this.b = A_2;
		this.c = A_4;
		this.d = A_1;
		this.e = A_2;
		this.f = A_3;
	}

	// Token: 0x060074DC RID: 29916 RVA: 0x00318EAC File Offset: 0x003170AC
	protected override dc4 dt()
	{
		this.h = 0.0;
		if (this.f == -1)
		{
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x060074DD RID: 29917 RVA: 0x00318ED0 File Offset: 0x003170D0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if ((this.h += A_1.TotalMilliseconds) >= (double)this.d)
		{
			this.h = 0.0;
			int num = this.b + 1;
			this.b = num;
			if (num > this.f)
			{
				this.b = this.e;
				num = this.i + 1;
				this.i = num;
				if (num >= this.c)
				{
					return dc4.c;
				}
			}
		}
		if (this.a() != null)
		{
			this.a().b(this.b);
		}
		return dc4.b;
	}

	// Token: 0x04002FCC RID: 12236
	private new EntityAspectReference<ka, ka> a;

	// Token: 0x04002FCD RID: 12237
	private int b;

	// Token: 0x04002FCE RID: 12238
	private int c = 1;

	// Token: 0x04002FCF RID: 12239
	private int d;

	// Token: 0x04002FD0 RID: 12240
	private int e;

	// Token: 0x04002FD1 RID: 12241
	private int f;

	// Token: 0x04002FD2 RID: 12242
	private EntityAspectReference<amc, amc> g;

	// Token: 0x04002FD3 RID: 12243
	private double h;

	// Token: 0x04002FD4 RID: 12244
	private int i;
}
