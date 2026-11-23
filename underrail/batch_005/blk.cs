using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000365 RID: 869
[eiz("CTI")]
[Serializable]
public sealed class blk : ISerializable
{
	// Token: 0x0600184F RID: 6223 RVA: 0x0007B464 File Offset: 0x00079664
	private blk(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("CTI:CAR", typeof(EntityAspectReference<amc, amc>));
			this.b = (erl)A_0.GetValue("CTI:D", typeof(erl));
			this.c = (h)A_0.GetValue("CTI:A", typeof(h));
			this.d = A_0.GetBoolean("CTI:IS");
			return;
		}
		if (base.GetType() == typeof(blk))
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("_CharacterAspectRef", typeof(EntityAspectReference<amc, amc>));
			this.b = (erl)A_0.GetValue("_Detection", typeof(erl));
			this.c = (h)A_0.GetValue("_Attitude", typeof(h));
			this.d = A_0.GetBoolean("_InSight");
			return;
		}
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("CharacterTrackingInfo+_CharacterAspectRef", typeof(EntityAspectReference<amc, amc>));
		this.b = (erl)A_0.GetValue("CharacterTrackingInfo+_Detection", typeof(erl));
		this.c = (h)A_0.GetValue("CharacterTrackingInfo+_Attitude", typeof(h));
		this.d = A_0.GetBoolean("CharacterTrackingInfo+_InSight");
	}

	// Token: 0x06001850 RID: 6224 RVA: 0x0007B5F0 File Offset: 0x000797F0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CTI:CAR", this.a);
		info.AddValue("CTI:D", this.b);
		info.AddValue("CTI:A", this.c);
		info.AddValue("CTI:IS", this.d);
	}

	// Token: 0x06001851 RID: 6225 RVA: 0x0007B648 File Offset: 0x00079848
	public EntityAspectReference<amc, amc> d()
	{
		return this.a;
	}

	// Token: 0x06001852 RID: 6226 RVA: 0x0007B650 File Offset: 0x00079850
	public erl a()
	{
		return this.b;
	}

	// Token: 0x06001853 RID: 6227 RVA: 0x0007B658 File Offset: 0x00079858
	public amc e()
	{
		if (this.a != null)
		{
			return this.a.ao();
		}
		return null;
	}

	// Token: 0x06001854 RID: 6228 RVA: 0x0007B674 File Offset: 0x00079874
	public h f()
	{
		return this.c;
	}

	// Token: 0x06001855 RID: 6229 RVA: 0x0007B67C File Offset: 0x0007987C
	public void a(h A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001856 RID: 6230 RVA: 0x0007B688 File Offset: 0x00079888
	public bool b()
	{
		return this.d;
	}

	// Token: 0x06001857 RID: 6231 RVA: 0x0007B690 File Offset: 0x00079890
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06001858 RID: 6232 RVA: 0x0007B69C File Offset: 0x0007989C
	public blk(amc A_0, h A_1)
	{
		this.c = A_1;
		if (A_0 != null)
		{
			this.a = new EntityAspectReference<amc, amc>(A_0);
			this.b = new erl(A_0.aa().SpecialStates.g);
			return;
		}
		this.b = new erl(false);
	}

	// Token: 0x06001859 RID: 6233 RVA: 0x0007B6F0 File Offset: 0x000798F0
	private blk()
	{
	}

	// Token: 0x0600185A RID: 6234 RVA: 0x0007B6F8 File Offset: 0x000798F8
	public blk c()
	{
		return new blk
		{
			a = this.a,
			c = this.c,
			b = this.b.e(),
			d = this.d
		};
	}

	// Token: 0x04000E40 RID: 3648
	private EntityAspectReference<amc, amc> a;

	// Token: 0x04000E41 RID: 3649
	private erl b;

	// Token: 0x04000E42 RID: 3650
	private h c;

	// Token: 0x04000E43 RID: 3651
	private bool d;
}
