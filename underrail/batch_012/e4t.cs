using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200144F RID: 5199
[eiz("PCAA")]
[Serializable]
public sealed class e4t : b1z, bgn, ISerializable
{
	// Token: 0x060074DE RID: 29918 RVA: 0x00318F74 File Offset: 0x00317174
	private e4t(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (CharacterState)A_0.GetValue("PCAA:S", typeof(CharacterState));
		this.b = A_0.GetInt32("PCAA:P");
		this.c = A_0.GetInt32("PCAA:C");
		this.d = A_0.GetInt32("PCAA.PS");
		this.g = (A_0.GetValue("PCAA:CR", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.h = A_0.GetDouble("PCAA:PCH");
		this.i = A_0.GetInt32("PCAA:CD");
		this.e = A_0.GetInt32("PCAA:SP");
		this.f = A_0.GetInt32("PCAA:EP");
	}

	// Token: 0x060074DF RID: 29919 RVA: 0x00319050 File Offset: 0x00317250
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PCAA:S", this.a);
		info.AddValue("PCAA:P", this.b);
		info.AddValue("PCAA:C", this.c);
		info.AddValue("PCAA.PS", this.d);
		info.AddValue("PCAA:CR", this.g);
		info.AddValue("PCAA:PCH", this.h);
		info.AddValue("PCAA:CD", this.i);
		info.AddValue("PCAA:SP", this.e);
		info.AddValue("PCAA:EP", this.f);
	}

	// Token: 0x060074E0 RID: 29920 RVA: 0x00319104 File Offset: 0x00317304
	public override m7 kh()
	{
		return m7.b;
	}

	// Token: 0x060074E1 RID: 29921 RVA: 0x00319108 File Offset: 0x00317308
	public int? tm()
	{
		return new int?(this.b);
	}

	// Token: 0x060074E2 RID: 29922 RVA: 0x00319118 File Offset: 0x00317318
	public CharacterState? q1()
	{
		return new CharacterState?(this.a);
	}

	// Token: 0x060074E3 RID: 29923 RVA: 0x00319128 File Offset: 0x00317328
	public object fm()
	{
		return null;
	}

	// Token: 0x060074E4 RID: 29924 RVA: 0x0031912C File Offset: 0x0031732C
	public ci8? oi()
	{
		return null;
	}

	// Token: 0x060074E5 RID: 29925 RVA: 0x00319144 File Offset: 0x00317344
	public e4t(EntityAspectReference<amc, amc> A_0, CharacterState A_1, int A_2, int A_3 = 0, int? A_4 = null, int A_5 = 1)
	{
		this.g = A_0;
		this.a = A_1;
		this.b = A_3;
		this.c = A_5;
		this.d = A_2;
		this.e = A_3;
		if (A_4 != null)
		{
			this.f = A_4.Value;
		}
	}

	// Token: 0x060074E6 RID: 29926 RVA: 0x003191AC File Offset: 0x003173AC
	public e4t(amc A_0, CharacterState A_1, int A_2, int A_3 = 0, int? A_4 = null, int A_5 = 1) : this(new EntityAspectReference<amc, amc>(A_0), A_1, A_2, A_3, A_4, A_5)
	{
	}

	// Token: 0x060074E7 RID: 29927 RVA: 0x003191C4 File Offset: 0x003173C4
	protected override dc4 dt()
	{
		if (this.f == -1)
		{
			this.f = this.a() - 1;
		}
		this.h = 0.0;
		if (this.f == -1)
		{
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x060074E8 RID: 29928 RVA: 0x00319200 File Offset: 0x00317400
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
		return dc4.b;
	}

	// Token: 0x060074E9 RID: 29929 RVA: 0x00319288 File Offset: 0x00317488
	private int a()
	{
		if (this.g != null && this.g.ao() != null)
		{
			am5 am;
			this.g.ao().e.TryGetValue(this.a, out am);
			if (am != null)
			{
				return am.a;
			}
		}
		return -1;
	}

	// Token: 0x04002FD5 RID: 12245
	private new CharacterState a;

	// Token: 0x04002FD6 RID: 12246
	private int b;

	// Token: 0x04002FD7 RID: 12247
	private int c = 1;

	// Token: 0x04002FD8 RID: 12248
	private int d;

	// Token: 0x04002FD9 RID: 12249
	private int e;

	// Token: 0x04002FDA RID: 12250
	private int f = -1;

	// Token: 0x04002FDB RID: 12251
	private EntityAspectReference<amc, amc> g;

	// Token: 0x04002FDC RID: 12252
	private double h;

	// Token: 0x04002FDD RID: 12253
	private int i;
}
