using System;
using System.Runtime.Serialization;

// Token: 0x020009DC RID: 2524
[eiz("SODPP0")]
[Serializable]
public sealed class br0 : bdw, ISerializable
{
	// Token: 0x06003C6B RID: 15467 RVA: 0x0016617C File Offset: 0x0016437C
	private br0(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C6C RID: 15468 RVA: 0x00166184 File Offset: 0x00164384
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C6D RID: 15469 RVA: 0x00166188 File Offset: 0x00164388
	public br0()
	{
	}

	// Token: 0x06003C6E RID: 15470 RVA: 0x00166194 File Offset: 0x00164394
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			csd a_ = A_0.g("supportGuard1");
			csd a_2 = A_0.g("supportGuard2");
			c5x c5x = null;
			c5x c5x2 = null;
			string a_3 = null;
			if (A_1.r().GetPrimitivePropertyValue<bool>("quest_jygetSupportForEels_gotSgsSupport", new bool?(false)).Value)
			{
				c5x = vq.a("creature\\characters\\support\\sgsSupport1", a_, true);
				c5x2 = vq.a("creature\\characters\\support\\sgsSupport2", a_2, true);
				a_3 = "jy_sgsDockGuard";
			}
			else if (A_1.r().GetPrimitivePropertyValue<bool>("quest_jygetSupportForEels_gotUSSupport", new bool?(false)).Value)
			{
				c5x = vq.a("creature\\characters\\support\\jyUsSupport1", a_, true);
				c5x2 = vq.a("creature\\characters\\support\\jyUsSupport2", a_2, true);
				a_3 = "jy_protectorateGuard";
			}
			if (c5x != null)
			{
				cgh.a(c5x, "supportGuard1");
				this.a(c5x, a_3);
			}
			if (c5x2 != null)
			{
				cgh.a(c5x2, "supportGuard2");
				this.a(c5x2, a_3);
			}
		}
	}

	// Token: 0x06003C6F RID: 15471 RVA: 0x0016628C File Offset: 0x0016448C
	private void a(c5x A_0, string A_1)
	{
		bn5 bn = A_0.GetAspect<j7>() as bn5;
		if (bn == null)
		{
			bn = new bn5(A_0);
			A_0.SetAspect<j7>(bn);
		}
		bn.b(true);
		bn.a("speaker");
		bn.b("support\\" + A_1);
	}
}
