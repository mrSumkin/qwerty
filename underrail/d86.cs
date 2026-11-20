using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000FDA RID: 4058
[eiz("AE1")]
[Serializable]
public sealed class d86 : esc, ISerializable
{
	// Token: 0x06005382 RID: 21378 RVA: 0x00250A08 File Offset: 0x0024EC08
	private d86(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("AE1:XP");
	}

	// Token: 0x06005383 RID: 21379 RVA: 0x00250A24 File Offset: 0x0024EC24
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("AE1:XP", this.a);
	}

	// Token: 0x06005384 RID: 21380 RVA: 0x00250A40 File Offset: 0x0024EC40
	public int a()
	{
		return this.a;
	}

	// Token: 0x06005385 RID: 21381 RVA: 0x00250A48 File Offset: 0x0024EC48
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005386 RID: 21382 RVA: 0x00250A54 File Offset: 0x0024EC54
	public d86()
	{
	}

	// Token: 0x06005387 RID: 21383 RVA: 0x00250A5C File Offset: 0x0024EC5C
	public d86(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005388 RID: 21384 RVA: 0x00250A70 File Offset: 0x0024EC70
	public override int d5(bq8 A_0, bq8 A_1)
	{
		if (this.a > 0)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().e() == ExperienceSystem.Classic)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					c5x.h.b.a(this.a, null);
					return 0;
				}
			}
		}
		return -1;
	}

	// Token: 0x04002212 RID: 8722
	private int a;
}
