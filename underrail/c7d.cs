using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000C6A RID: 3178
[eiz("SGSCAC2")]
[Serializable]
public sealed class c7d : dnh
{
	// Token: 0x06004781 RID: 18305 RVA: 0x001D7738 File Offset: 0x001D5938
	private c7d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SGSCAC2:C");
	}

	// Token: 0x06004782 RID: 18306 RVA: 0x001D7754 File Offset: 0x001D5954
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGSCAC2:C", this.a);
	}

	// Token: 0x06004783 RID: 18307 RVA: 0x001D7770 File Offset: 0x001D5970
	public string a()
	{
		return this.a;
	}

	// Token: 0x06004784 RID: 18308 RVA: 0x001D7778 File Offset: 0x001D5978
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004785 RID: 18309 RVA: 0x001D7784 File Offset: 0x001D5984
	public c7d()
	{
	}

	// Token: 0x06004786 RID: 18310 RVA: 0x001D7790 File Offset: 0x001D5990
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			HashSet<string> classPropertyValue = A_1.GetClassPropertyValue<HashSet<string>>("clueList");
			if (classPropertyValue != null)
			{
				return classPropertyValue.Contains(this.a.ToUpperInvariant());
			}
		}
		return false;
	}

	// Token: 0x04001C9C RID: 7324
	private string a;
}
