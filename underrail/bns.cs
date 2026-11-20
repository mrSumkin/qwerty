using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001A60 RID: 6752
[eiz("WAM")]
[Serializable]
public abstract class bns : ISerializable
{
	// Token: 0x0600928D RID: 37517 RVA: 0x0039FBD0 File Offset: 0x0039DDD0
	protected bns(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600928E RID: 37518 RVA: 0x0039FBD8 File Offset: 0x0039DDD8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x1700026B RID: 619
	// (get) Token: 0x0600928F RID: 37519 RVA: 0x0039FBDC File Offset: 0x0039DDDC
	public virtual bool Negative
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06009290 RID: 37520 RVA: 0x0039FBE0 File Offset: 0x0039DDE0
	protected bns()
	{
	}

	// Token: 0x06009291 RID: 37521 RVA: 0x0039FBE8 File Offset: 0x0039DDE8
	public virtual double rk(cd1 A_0, efk A_1, efk A_2, double A_3, double A_4, bool A_5, AmmoType A_6, bool A_7, bool A_8)
	{
		return 0.0;
	}

	// Token: 0x06009292 RID: 37522 RVA: 0x0039FBF4 File Offset: 0x0039DDF4
	public virtual double rl(cd1 A_0, efk A_1, efk A_2, bool A_3)
	{
		return 0.0;
	}

	// Token: 0x06009293 RID: 37523 RVA: 0x0039FC00 File Offset: 0x0039DE00
	public virtual double af6(efk A_0, bool A_1)
	{
		return 0.0;
	}

	// Token: 0x06009294 RID: 37524 RVA: 0x0039FC0C File Offset: 0x0039DE0C
	public virtual double hz(cd1 A_0, efk A_1, efk A_2, double A_3, double A_4, bool A_5, AmmoType A_6, bool A_7)
	{
		return 0.0;
	}

	// Token: 0x06009295 RID: 37525 RVA: 0x0039FC18 File Offset: 0x0039DE18
	public virtual double hy(cd1 A_0, efk A_1, efk A_2)
	{
		return 0.0;
	}

	// Token: 0x06009296 RID: 37526 RVA: 0x0039FC24 File Offset: 0x0039DE24
	public virtual void atf(cmn A_0, cd1 A_1, efk A_2, efk A_3)
	{
	}

	// Token: 0x06009297 RID: 37527 RVA: 0x0039FC28 File Offset: 0x0039DE28
	public virtual void ate(cmn A_0, cd1 A_1, efk A_2, efk A_3, double A_4, double A_5, bool A_6, AmmoType A_7, bool A_8)
	{
	}

	// Token: 0x06009298 RID: 37528 RVA: 0x0039FC2C File Offset: 0x0039DE2C
	public virtual void lk(ref csk A_0, cd1 A_1, efk A_2, efk A_3, bool A_4)
	{
	}

	// Token: 0x06009299 RID: 37529 RVA: 0x0039FC30 File Offset: 0x0039DE30
	public virtual void ll(ref csk A_0, cd1 A_1, efk A_2, efk A_3, double A_4, double A_5, bool A_6, AmmoType A_7, bool A_8, bool A_9)
	{
	}

	// Token: 0x0600929A RID: 37530
	public abstract string h0(cd1 A_0);

	// Token: 0x0600929B RID: 37531 RVA: 0x0039FC34 File Offset: 0x0039DE34
	public override string ToString()
	{
		return this.a(null);
	}

	// Token: 0x0600929C RID: 37532 RVA: 0x0039FC40 File Offset: 0x0039DE40
	public string a(cd1 A_0)
	{
		string text = this.h0(A_0);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return base.GetType().Name;
	}

	// Token: 0x0600929D RID: 37533
	public abstract bns h1();

	// Token: 0x0600929E RID: 37534 RVA: 0x0039FC70 File Offset: 0x0039DE70
	protected virtual void h2(bns A_0)
	{
	}
}
