using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000465 RID: 1125
[eiz("RME")]
[Serializable]
internal sealed class ec8 : b1z, ISerializable
{
	// Token: 0x06001D40 RID: 7488 RVA: 0x000A251C File Offset: 0x000A071C
	private ec8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("RME:I", typeof(EntityAspectReference<bm6, bm6>)) as EntityAspectReference<bm6, bm6>);
	}

	// Token: 0x06001D41 RID: 7489 RVA: 0x000A2548 File Offset: 0x000A0748
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RME:I", this.a);
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x000A2564 File Offset: 0x000A0764
	public ec8(bm6 A_0)
	{
		this.a = new EntityAspectReference<bm6, bm6>(A_0);
	}

	// Token: 0x06001D43 RID: 7491 RVA: 0x000A2578 File Offset: 0x000A0778
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null)
		{
			return dc4.e;
		}
		int? num = this.a.ao().y6().GetPrimitivePropertyValue<int>("lgMushroomsNeeded", new int?(0));
		if (num.Value > 0)
		{
			num--;
		}
		this.a.ao().y6()["lgMushroomsNeeded"] = num;
		return dc4.c;
	}

	// Token: 0x04001032 RID: 4146
	private new EntityAspectReference<bm6, bm6> a;
}
