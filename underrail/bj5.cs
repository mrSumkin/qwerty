using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common.Conditions;

// Token: 0x020004BF RID: 1215
[eiz("COCO")]
[Serializable]
public sealed class bj5 : dth, ISerializable
{
	// Token: 0x06001F0C RID: 7948 RVA: 0x000AC024 File Offset: 0x000AA224
	private bj5(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<dth>("COCO:C", ref this.a, A_0);
		this.b = (CompositeConditionOperation)A_0.GetValue("COCO:O", typeof(CompositeConditionOperation));
	}

	// Token: 0x06001F0D RID: 7949 RVA: 0x000AC074 File Offset: 0x000AA274
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		di7.WriteList<dth>("COCO:C", this.a, info);
		info.AddValue("COCO:O", this.b);
	}

	// Token: 0x06001F0E RID: 7950 RVA: 0x000AC0A0 File Offset: 0x000AA2A0
	public List<dth> b()
	{
		return this.a;
	}

	// Token: 0x06001F0F RID: 7951 RVA: 0x000AC0A8 File Offset: 0x000AA2A8
	public void a(List<dth> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001F10 RID: 7952 RVA: 0x000AC0B4 File Offset: 0x000AA2B4
	public CompositeConditionOperation a()
	{
		return this.b;
	}

	// Token: 0x06001F11 RID: 7953 RVA: 0x000AC0BC File Offset: 0x000AA2BC
	public void a(CompositeConditionOperation A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001F12 RID: 7954 RVA: 0x000AC0C8 File Offset: 0x000AA2C8
	public bj5()
	{
	}

	// Token: 0x06001F13 RID: 7955 RVA: 0x000AC0E0 File Offset: 0x000AA2E0
	public bool jh(object A_0)
	{
		if (this.b == CompositeConditionOperation.And)
		{
			using (List<dth>.Enumerator enumerator = this.a.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.jh(A_0))
					{
						return false;
					}
				}
			}
			return true;
		}
		if (this.b == CompositeConditionOperation.Or)
		{
			using (List<dth>.Enumerator enumerator = this.a.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.jh(A_0))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001F14 RID: 7956 RVA: 0x000AC1B4 File Offset: 0x000AA3B4
	public string ji()
	{
		if (this.a.Count > 0)
		{
			string text = "";
			bool flag = true;
			foreach (dth dth in this.a)
			{
				if (dth != null)
				{
					if (!flag)
					{
						flag = false;
						text += string.Format(" {0} ", this.b.ToString().ToLowerInvariant());
					}
					text += dth.ji();
				}
			}
			return text;
		}
		return string.Format("Empty {0} composite condition", this.b.ToString().ToLowerInvariant());
	}

	// Token: 0x040013AB RID: 5035
	private List<dth> a = new List<dth>();

	// Token: 0x040013AC RID: 5036
	private CompositeConditionOperation b;
}
