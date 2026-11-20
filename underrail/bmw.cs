using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020018B9 RID: 6329
[eiz("QC")]
[Serializable]
public sealed class bmw : ISerializable
{
	// Token: 0x06008652 RID: 34386 RVA: 0x0037B220 File Offset: 0x00379420
	private bmw(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("QC:AQ", typeof(List<eza>)) as List<eza>);
		this.b = (A_0.GetValue("QC:CQ", typeof(List<eza>)) as List<eza>);
		if (ell.a() >= 102)
		{
			this.c = (A_0.GetValue("QC:FQ", typeof(List<eza>)) as List<eza>);
		}
	}

	// Token: 0x06008653 RID: 34387 RVA: 0x0037B2C0 File Offset: 0x003794C0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("QC:AQ", this.a);
		info.AddValue("QC:CQ", this.b);
		info.AddValue("QC:FQ", this.c);
	}

	// Token: 0x06008654 RID: 34388 RVA: 0x0037B2F8 File Offset: 0x003794F8
	public List<eza> c()
	{
		return this.a;
	}

	// Token: 0x06008655 RID: 34389 RVA: 0x0037B300 File Offset: 0x00379500
	public List<eza> a()
	{
		return this.b;
	}

	// Token: 0x06008656 RID: 34390 RVA: 0x0037B308 File Offset: 0x00379508
	public List<eza> b()
	{
		return this.c;
	}

	// Token: 0x06008657 RID: 34391 RVA: 0x0037B310 File Offset: 0x00379510
	public bmw()
	{
	}

	// Token: 0x06008658 RID: 34392 RVA: 0x0037B33C File Offset: 0x0037953C
	public int d()
	{
		int num = 0;
		using (IEnumerator<eza> enumerator = Enumerable.Union<eza>(Enumerable.Union<eza>(this.a, this.b), this.c).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.Read)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x04003382 RID: 13186
	private List<eza> a = new List<eza>();

	// Token: 0x04003383 RID: 13187
	private List<eza> b = new List<eza>();

	// Token: 0x04003384 RID: 13188
	private List<eza> c = new List<eza>();
}
