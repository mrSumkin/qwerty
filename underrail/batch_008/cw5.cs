using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000F9E RID: 3998
[eiz("PAJ1")]
[Serializable]
public sealed class cw5 : cze, ISerializable
{
	// Token: 0x0600519F RID: 20895 RVA: 0x0024BCE4 File Offset: 0x00249EE4
	private cw5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (CharacterState)A_0.GetValue("PAJ1:A", typeof(CharacterState));
		this.b = A_0.GetInt32("PAJ1:P");
		this.c = A_0.GetInt32("PAJ1:S");
		this.d = (A_0.GetValue("PAJ1:E", typeof(int?)) as int?);
		this.e = A_0.GetInt32("PAJ1:C");
		this.f = (Guid?)A_0.GetValue("PAJ1:I", typeof(Guid?));
		this.g = A_0.GetString("PAJ1:AR");
		this.h = A_0.GetBoolean("PAJ1:T");
	}

	// Token: 0x060051A0 RID: 20896 RVA: 0x0024BDC8 File Offset: 0x00249FC8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PAJ1:A", this.a);
		info.AddValue("PAJ1:P", this.b);
		info.AddValue("PAJ1:S", this.c);
		info.AddValue("PAJ1:E", this.d);
		info.AddValue("PAJ1:C", this.e);
		info.AddValue("PAJ1:I", this.f);
		info.AddValue("PAJ1:AR", this.g);
		info.AddValue("PAJ1:T", this.h);
	}

	// Token: 0x060051A1 RID: 20897 RVA: 0x0024BE74 File Offset: 0x0024A074
	public CharacterState b()
	{
		return this.a;
	}

	// Token: 0x060051A2 RID: 20898 RVA: 0x0024BE7C File Offset: 0x0024A07C
	public void a(CharacterState A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060051A3 RID: 20899 RVA: 0x0024BE88 File Offset: 0x0024A088
	public int h()
	{
		return this.b;
	}

	// Token: 0x060051A4 RID: 20900 RVA: 0x0024BE90 File Offset: 0x0024A090
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060051A5 RID: 20901 RVA: 0x0024BE9C File Offset: 0x0024A09C
	public int g()
	{
		return this.c;
	}

	// Token: 0x060051A6 RID: 20902 RVA: 0x0024BEA4 File Offset: 0x0024A0A4
	public void c(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060051A7 RID: 20903 RVA: 0x0024BEB0 File Offset: 0x0024A0B0
	public int? a()
	{
		return this.d;
	}

	// Token: 0x060051A8 RID: 20904 RVA: 0x0024BEB8 File Offset: 0x0024A0B8
	public void a(int? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060051A9 RID: 20905 RVA: 0x0024BEC4 File Offset: 0x0024A0C4
	public int e()
	{
		return this.e;
	}

	// Token: 0x060051AA RID: 20906 RVA: 0x0024BECC File Offset: 0x0024A0CC
	public void b(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060051AB RID: 20907 RVA: 0x0024BED8 File Offset: 0x0024A0D8
	public string d()
	{
		return this.g;
	}

	// Token: 0x060051AC RID: 20908 RVA: 0x0024BEE0 File Offset: 0x0024A0E0
	public void a(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060051AD RID: 20909 RVA: 0x0024BEEC File Offset: 0x0024A0EC
	public Guid? f()
	{
		return this.f;
	}

	// Token: 0x060051AE RID: 20910 RVA: 0x0024BEF4 File Offset: 0x0024A0F4
	public void a(Guid? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060051AF RID: 20911 RVA: 0x0024BF00 File Offset: 0x0024A100
	public bool c()
	{
		return this.h;
	}

	// Token: 0x060051B0 RID: 20912 RVA: 0x0024BF08 File Offset: 0x0024A108
	public void a(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060051B1 RID: 20913 RVA: 0x0024BF14 File Offset: 0x0024A114
	public cw5()
	{
	}

	// Token: 0x060051B2 RID: 20914 RVA: 0x0024BF30 File Offset: 0x0024A130
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.h && serviceOrThrow.aqu() != null)
		{
			c5x = (serviceOrThrow.aqu().v().b() as c5x);
		}
		else if (this.f != null)
		{
			aud aud = cze.a(this.g, A_0, A_1, A_2);
			if (aud != null)
			{
				c5x = (aud.a(this.f.Value) as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null && c5x.h.b != null)
		{
			awx awx = new awx();
			awx.a(m7.b);
			awx.ad().Add(new e4t(c5x.h.b, this.a, this.b, this.c, this.d, this.e));
			if (c5x.i.b != null)
			{
				c5x.i.b.b(awx, atp.a);
			}
		}
	}

	// Token: 0x04002180 RID: 8576
	private new CharacterState a;

	// Token: 0x04002181 RID: 8577
	private int b = cux.a;

	// Token: 0x04002182 RID: 8578
	private int c;

	// Token: 0x04002183 RID: 8579
	private int? d;

	// Token: 0x04002184 RID: 8580
	private int e = 1;

	// Token: 0x04002185 RID: 8581
	private Guid? f;

	// Token: 0x04002186 RID: 8582
	private string g;

	// Token: 0x04002187 RID: 8583
	private bool h;
}
