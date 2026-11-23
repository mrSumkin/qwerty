using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001112 RID: 4370
[eiz("S10")]
[Serializable]
public sealed class bzm : cze
{
	// Token: 0x06005D10 RID: 23824 RVA: 0x0027A6C8 File Offset: 0x002788C8
	private bzm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("S10:N");
		this.b = A_0.GetBoolean("S10:E");
	}

	// Token: 0x06005D11 RID: 23825 RVA: 0x0027A6F4 File Offset: 0x002788F4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S10:N", this.a);
		info.AddValue("S10:E", this.b);
	}

	// Token: 0x06005D12 RID: 23826 RVA: 0x0027A720 File Offset: 0x00278920
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06005D13 RID: 23827 RVA: 0x0027A728 File Offset: 0x00278928
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005D14 RID: 23828 RVA: 0x0027A734 File Offset: 0x00278934
	public string b()
	{
		return this.a;
	}

	// Token: 0x06005D15 RID: 23829 RVA: 0x0027A73C File Offset: 0x0027893C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005D16 RID: 23830 RVA: 0x0027A748 File Offset: 0x00278948
	public bzm()
	{
	}

	// Token: 0x06005D17 RID: 23831 RVA: 0x0027A754 File Offset: 0x00278954
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c1a c1a = null;
		if (A_0 != null)
		{
			c1a = A_0.Zone;
		}
		if (c1a == null && A_1 != null)
		{
			c1a = A_1.Zone;
		}
		if (c1a != null && !string.IsNullOrEmpty(this.a))
		{
			ah7 ah = c1a.i(this.a);
			if (ah != null)
			{
				ah.Enabled = this.b;
				ah.d();
			}
		}
	}

	// Token: 0x04002520 RID: 9504
	private new string a;

	// Token: 0x04002521 RID: 9505
	private bool b;
}
