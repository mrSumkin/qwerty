using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200190E RID: 6414
[eiz("PMI")]
[Serializable]
public sealed class eml : dj3, ISerializable, c6m
{
	// Token: 0x0600882B RID: 34859 RVA: 0x003864E4 File Offset: 0x003846E4
	private eml(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("PMI:P");
	}

	// Token: 0x0600882C RID: 34860 RVA: 0x00386500 File Offset: 0x00384700
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PMI:P", this.a);
	}

	// Token: 0x0600882D RID: 34861 RVA: 0x0038651C File Offset: 0x0038471C
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600882E RID: 34862 RVA: 0x00386524 File Offset: 0x00384724
	public new void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600882F RID: 34863 RVA: 0x00386530 File Offset: 0x00384730
	public override string tv()
	{
		return "Наставник";
	}

	// Token: 0x06008830 RID: 34864 RVA: 0x00386538 File Offset: 0x00384738
	public eml()
	{
		this.a();
	}

	// Token: 0x06008831 RID: 34865 RVA: 0x00386548 File Offset: 0x00384748
	public eml(string A_0) : this()
	{
		this.a = A_0;
	}

	// Token: 0x06008832 RID: 34866 RVA: 0x00386558 File Offset: 0x00384758
	public override bk3 tw()
	{
		eml eml = new eml();
		this.ai7(eml);
		return eml;
	}

	// Token: 0x06008833 RID: 34867 RVA: 0x00386574 File Offset: 0x00384774
	public List<brl> j0()
	{
		c7i c7i = dgk.a(this.a) as c7i;
		if (c7i != null)
		{
			return c7i.ck();
		}
		return null;
	}

	// Token: 0x06008834 RID: 34868 RVA: 0x003865A0 File Offset: 0x003847A0
	private new void a()
	{
		base.a2().Add(new aia(typeof(caj)));
	}

	// Token: 0x06008835 RID: 34869 RVA: 0x003865BC File Offset: 0x003847BC
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		eml eml = A_0 as eml;
		if (eml != null)
		{
			eml.a = this.a;
		}
	}

	// Token: 0x0400366C RID: 13932
	private new string a;
}
