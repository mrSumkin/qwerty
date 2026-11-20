using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200140A RID: 5130
[eiz("TWUIEA")]
[Serializable]
public sealed class nu : b1z, ISerializable
{
	// Token: 0x06007337 RID: 29495 RVA: 0x00308EA0 File Offset: 0x003070A0
	private nu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("TWUIEA:S", typeof(EntityAspectReference<amc, amc>));
		this.b = (A_0.GetValue("TWUIEA:W", typeof(Guid?)) as Guid?);
		this.c = A_0.GetBoolean("TWUIEA:T");
	}

	// Token: 0x06007338 RID: 29496 RVA: 0x00308F0C File Offset: 0x0030710C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TWUIEA:S", this.a);
		info.AddValue("TWUIEA:W", this.b);
		info.AddValue("TWUIEA:T", this.c);
	}

	// Token: 0x06007339 RID: 29497 RVA: 0x00308F5C File Offset: 0x0030715C
	public nu(amc A_0, cd1 A_1, bool A_2)
	{
		czh.a(A_0, "subject");
		this.a = new EntityAspectReference<amc, amc>(A_0);
		if (A_1 != null)
		{
			this.b = new Guid?(A_1.Id);
		}
		this.c = A_2;
	}

	// Token: 0x0600733A RID: 29498 RVA: 0x00308F9C File Offset: 0x0030719C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a.ao() != null)
		{
			bk0.b(this.a.ao().aa(), this.b, this.c);
		}
		return dc4.c;
	}

	// Token: 0x04002F16 RID: 12054
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04002F17 RID: 12055
	private Guid? b;

	// Token: 0x04002F18 RID: 12056
	private bool c;
}
