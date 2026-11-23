using System;
using System.Runtime.Serialization;

// Token: 0x020004EA RID: 1258
[eiz("SIAAP")]
[Serializable]
public abstract class cdg : esc, ISerializable
{
	// Token: 0x0600207C RID: 8316 RVA: 0x000AFF4C File Offset: 0x000AE14C
	protected cdg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SIAAP:I");
	}

	// Token: 0x0600207D RID: 8317 RVA: 0x000AFF74 File Offset: 0x000AE174
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SIAAP:I", this.a);
	}

	// Token: 0x0600207E RID: 8318 RVA: 0x000AFF90 File Offset: 0x000AE190
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600207F RID: 8319 RVA: 0x000AFF98 File Offset: 0x000AE198
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002080 RID: 8320 RVA: 0x000AFFA4 File Offset: 0x000AE1A4
	public cdg()
	{
	}

	// Token: 0x06002081 RID: 8321 RVA: 0x000AFFBC File Offset: 0x000AE1BC
	public override int d5(bq8 A_0, bq8 A_1)
	{
		if (pp.a != null && pp.a.aky() != null)
		{
			x4 x = pp.a.aky().n0(this.a) as x4;
			if (x != null)
			{
				this.ah6(x);
			}
		}
		return 0;
	}

	// Token: 0x06002082 RID: 8322
	protected abstract void ah6(x4 A_0);

	// Token: 0x06002083 RID: 8323 RVA: 0x000B000C File Offset: 0x000AE20C
	public override bool h5(string A_0, bool A_1)
	{
		return !base.h5(A_0, A_1) && !string.IsNullOrEmpty(this.a) && this.a.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1;
	}

	// Token: 0x04001419 RID: 5145
	private string a = "interface";
}
