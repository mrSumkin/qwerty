using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02000261 RID: 609
[eiz("LDRF")]
[Serializable]
public sealed class jy : TypedObjectReference<ah7>, ISerializable
{
	// Token: 0x0600117E RID: 4478 RVA: 0x00048054 File Offset: 0x00046254
	private jy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("LDRF:ZR", typeof(a55)) as a55);
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x00048080 File Offset: 0x00046280
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("LDRF:ZR", this.a);
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x000480A0 File Offset: 0x000462A0
	public jy(ah7 A_0)
	{
		if (A_0 != null && A_0.Zone != null)
		{
			base.a(new Guid?(A_0.Id));
			this.a = new a55(A_0.Zone);
			base.a(A_0);
		}
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x000480F0 File Offset: 0x000462F0
	protected override ah7 h4()
	{
		if (this.a != null && base.afl() != null && this.a.ao() != null)
		{
			return this.a.ao().a(base.afl().Value);
		}
		return null;
	}

	// Token: 0x040009E0 RID: 2528
	private a55 a;
}
