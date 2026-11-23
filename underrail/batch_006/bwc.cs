using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B3B RID: 2875
[eiz("CVSWS")]
[Serializable]
public sealed class bwc : cze, ISerializable
{
	// Token: 0x06004227 RID: 16935 RVA: 0x0019A464 File Offset: 0x00198664
	private bwc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("CVSWS:C");
		this.b = A_0.GetBoolean("CVSWS:E");
	}

	// Token: 0x06004228 RID: 16936 RVA: 0x0019A490 File Offset: 0x00198690
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CVSWS:C", this.a);
		info.AddValue("CVSWS:E", this.b);
	}

	// Token: 0x06004229 RID: 16937 RVA: 0x0019A4BC File Offset: 0x001986BC
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600422A RID: 16938 RVA: 0x0019A4C4 File Offset: 0x001986C4
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600422B RID: 16939 RVA: 0x0019A4D0 File Offset: 0x001986D0
	public bool a()
	{
		return this.b;
	}

	// Token: 0x0600422C RID: 16940 RVA: 0x0019A4D8 File Offset: 0x001986D8
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600422D RID: 16941 RVA: 0x0019A4E4 File Offset: 0x001986E4
	public bwc()
	{
	}

	// Token: 0x0600422E RID: 16942 RVA: 0x0019A4EC File Offset: 0x001986EC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		w9.a(this.a, this.b);
	}

	// Token: 0x04001C22 RID: 7202
	private new string a;

	// Token: 0x04001C23 RID: 7203
	private bool b;
}
