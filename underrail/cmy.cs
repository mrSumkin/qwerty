using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020011D5 RID: 4565
[eiz("GSEAX2")]
[Serializable]
public sealed class cmy : ya, ISerializable, l2
{
	// Token: 0x060061F5 RID: 25077 RVA: 0x002A796C File Offset: 0x002A5B6C
	private cmy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("GSEAX2:E", typeof(EntityAspectReference<qn, qn>)) as EntityAspectReference<qn, qn>);
	}

	// Token: 0x060061F6 RID: 25078 RVA: 0x002A7998 File Offset: 0x002A5B98
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GSEAX2:E", this.a);
	}

	// Token: 0x060061F7 RID: 25079 RVA: 0x002A79B4 File Offset: 0x002A5BB4
	public EntityAspectReference<qn, qn> a()
	{
		return this.a;
	}

	// Token: 0x060061F8 RID: 25080 RVA: 0x002A79BC File Offset: 0x002A5BBC
	public cmy(qn A_0)
	{
		if (A_0 != null)
		{
			this.a = new EntityAspectReference<qn, qn>(A_0);
		}
	}

	// Token: 0x060061F9 RID: 25081 RVA: 0x002A79DC File Offset: 0x002A5BDC
	public void jl(aud A_0)
	{
		if (this.a != null && this.a.afl() != null)
		{
			this.a = new EntityAspectReference<qn, qn>(A_0, this.a.afl().Value);
		}
	}

	// Token: 0x060061FA RID: 25082 RVA: 0x002A7A2C File Offset: 0x002A5C2C
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && this.a != null && this.a.ao() != null)
		{
			this.a.ao().a(c5x, true);
		}
	}

	// Token: 0x04002993 RID: 10643
	private EntityAspectReference<qn, qn> a;
}
