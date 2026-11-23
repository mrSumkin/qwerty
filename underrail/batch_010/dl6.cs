using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020004A5 RID: 1189
[eiz("RTL")]
[Serializable]
public sealed class dl6 : ISerializable
{
	// Token: 0x06001E38 RID: 7736 RVA: 0x000A8390 File Offset: 0x000A6590
	private dl6(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<bph>("RTL:S", ref this.a, A_0);
			return;
		}
		if (base.GetType() == typeof(dl6))
		{
			this.a = (List<bph>)A_0.GetValue("Sections", typeof(List<bph>));
			return;
		}
		this.a = (List<bph>)A_0.GetValue("RichTextLine+Sections", typeof(List<bph>));
	}

	// Token: 0x06001E39 RID: 7737 RVA: 0x000A8428 File Offset: 0x000A6628
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<bph>("RTL:S", this.a, info);
	}

	// Token: 0x06001E3A RID: 7738 RVA: 0x000A843C File Offset: 0x000A663C
	public dl6()
	{
	}

	// Token: 0x06001E3B RID: 7739 RVA: 0x000A8450 File Offset: 0x000A6650
	public dl6(IEnumerable<bph> A_0)
	{
		czh.a(A_0, "sections");
		this.a.AddRange(A_0);
	}

	// Token: 0x06001E3C RID: 7740 RVA: 0x000A8480 File Offset: 0x000A6680
	public bool a()
	{
		if (this.a != null)
		{
			foreach (bph bph in this.a)
			{
				if (bph != null && bph.b != null && !bph.b.Trim().Equals(string.Empty))
				{
					return false;
				}
			}
			return true;
		}
		return true;
	}

	// Token: 0x0400134E RID: 4942
	public List<bph> a = new List<bph>();
}
