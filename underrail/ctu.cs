using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02001E1E RID: 7710
[eiz("FR")]
[Serializable]
public sealed class ctu : TypedObjectReference<ai8>, ISerializable
{
	// Token: 0x0600AACD RID: 43725 RVA: 0x003F4BC4 File Offset: 0x003F2DC4
	private ctu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("FR:FTN");
			return;
		}
		if (base.GetType() == typeof(ctu))
		{
			this.a = A_0.GetString("_FullTypeName");
			return;
		}
		this.a = A_0.GetString("FeatReference+_FullTypeName");
	}

	// Token: 0x0600AACE RID: 43726 RVA: 0x003F4C34 File Offset: 0x003F2E34
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FR:FTN", this.a);
	}

	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x0600AACF RID: 43727 RVA: 0x003F4C50 File Offset: 0x003F2E50
	public string FullTypeName
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x0600AAD0 RID: 43728 RVA: 0x003F4C58 File Offset: 0x003F2E58
	public ctu(Type A_0)
	{
		czh.a(A_0, "featType");
		this.a = ck.a(A_0);
	}

	// Token: 0x0600AAD1 RID: 43729 RVA: 0x003F4C78 File Offset: 0x003F2E78
	protected override ai8 h4()
	{
		if (string.IsNullOrEmpty(this.a))
		{
			return null;
		}
		return ck.a(this.a);
	}

	// Token: 0x04003FCD RID: 16333
	private string a;
}
