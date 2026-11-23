using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02001085 RID: 4229
[eiz("PVHSJ")]
[Serializable]
public sealed class brg : cze
{
	// Token: 0x0600582C RID: 22572 RVA: 0x00264A28 File Offset: 0x00262C28
	private brg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600582D RID: 22573 RVA: 0x00264A34 File Offset: 0x00262C34
	public brg()
	{
	}

	// Token: 0x0600582E RID: 22574 RVA: 0x00264A40 File Offset: 0x00262C40
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null && serviceOrThrow.aqu() != null)
		{
			this.a(serviceOrThrow.aqu());
			foreach (aud aud in serviceOrThrow.aqw().Areas)
			{
				HashSet<c5x> hashSet = new HashSet<c5x>();
				foreach (ya ya in aud.Triggers)
				{
					bst bst = ya as bst;
					if (bst != null)
					{
						for (int i = bst.Location.X; i < bst.Location.X + bst.Size.c; i++)
						{
							for (int j = bst.Location.Y; j < bst.Location.Y + bst.Size.d; j++)
							{
								ak1 ak = bst.Area.b(i, j);
								if (ak != null)
								{
									foreach (b0b b0b in ak.c.Values)
									{
										c5x c5x = (c5x)b0b;
										if (!hashSet.Contains(c5x))
										{
											hashSet.Add(c5x);
											wv wv = c5x.s.b as wv;
											if (wv != null)
											{
												this.a(wv, serviceOrThrow.aqu());
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600582F RID: 22575 RVA: 0x00264C54 File Offset: 0x00262E54
	private void a(wv A_0, cyt A_1)
	{
		if (A_0.g() != null && A_0.g().an() != null && A_0.g().an().g() != null)
		{
			dic dic = new dic();
			dic.a(A_0.g().an().g().Definition.a5());
			dic.DisplayName = A_0.a8().y8();
			dic.a(this.a(A_0.g()));
			dic.a(A_0.g().ap().z2().Count == 0);
			dic.a(new ar7(A_0.a8()));
			if (A_0.g().l().Count > 0)
			{
				dic.b(A_0.g().l()[0]);
			}
			else
			{
				dic.b(asp.a);
			}
			A_1.r()[aya.a(dic.c())] = dic;
		}
	}

	// Token: 0x06005830 RID: 22576 RVA: 0x00264D60 File Offset: 0x00262F60
	private int a(bcx A_0)
	{
		int num = A_0.an().g().SingleItemValue / 2;
		foreach (agt agt in A_0.o().Values)
		{
			if (agt != null)
			{
				num += agt.ItemValue;
			}
		}
		return num / 30 / 100 * 100;
	}

	// Token: 0x06005831 RID: 22577 RVA: 0x00264DE4 File Offset: 0x00262FE4
	private void a(cyt A_0)
	{
		List<string> list = new List<string>();
		foreach (Property property in A_0.r().Properties)
		{
			if (property.Name.StartsWith(aya.a))
			{
				list.Add(property.Name);
			}
		}
		foreach (string name in list)
		{
			A_0.r().RemoveProperty(name);
		}
	}
}
