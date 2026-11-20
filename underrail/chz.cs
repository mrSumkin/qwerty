using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001020 RID: 4128
[eiz("CCBJ")]
[Serializable]
public sealed class chz : cze, ISerializable
{
	// Token: 0x0600552C RID: 21804 RVA: 0x0025A7F0 File Offset: 0x002589F0
	private chz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("CCBJ:I", typeof(Guid?));
		this.c = A_0.GetString("CCBJ:A");
		this.a = A_0.GetString("CCBJ:B");
	}

	// Token: 0x0600552D RID: 21805 RVA: 0x0025A848 File Offset: 0x00258A48
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCBJ:I", this.b);
		info.AddValue("CCBJ:A", this.c);
		info.AddValue("CCBJ:B", this.a);
	}

	// Token: 0x0600552E RID: 21806 RVA: 0x0025A898 File Offset: 0x00258A98
	public string c()
	{
		return this.a;
	}

	// Token: 0x0600552F RID: 21807 RVA: 0x0025A8A0 File Offset: 0x00258AA0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005530 RID: 21808 RVA: 0x0025A8AC File Offset: 0x00258AAC
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005531 RID: 21809 RVA: 0x0025A8B4 File Offset: 0x00258AB4
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005532 RID: 21810 RVA: 0x0025A8C0 File Offset: 0x00258AC0
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x06005533 RID: 21811 RVA: 0x0025A8C8 File Offset: 0x00258AC8
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005534 RID: 21812 RVA: 0x0025A8D4 File Offset: 0x00258AD4
	public chz()
	{
	}

	// Token: 0x06005535 RID: 21813 RVA: 0x0025A8DC File Offset: 0x00258ADC
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.b != null)
		{
			aud aud = cze.a(this.c, A_0, A_1, A_2);
			if (aud != null)
			{
				c5x = (new ar7(this.b.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null && c5x.t.b != null)
		{
			c5x.t.b.b(this.a);
		}
	}

	// Token: 0x040022B9 RID: 8889
	private new string a;

	// Token: 0x040022BA RID: 8890
	private Guid? b;

	// Token: 0x040022BB RID: 8891
	private string c;
}
