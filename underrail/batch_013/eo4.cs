using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;

// Token: 0x0200132B RID: 4907
[eiz("A10")]
[Serializable]
public sealed class eo4 : dvv, ISerializable
{
	// Token: 0x06006F29 RID: 28457 RVA: 0x002EAF4C File Offset: 0x002E914C
	private eo4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<string>("A10:D", ref this.b, A_0);
		this.a = A_0.GetString("A10:A");
		this.c = (A_0.GetValue("A10:P", typeof(ar7)) as ar7);
	}

	// Token: 0x06006F2A RID: 28458 RVA: 0x002EAFB0 File Offset: 0x002E91B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("A10:A", this.a);
		di7.WriteList<string>("A10:D", this.b, info);
		info.AddValue("A10:P", this.c);
	}

	// Token: 0x06006F2B RID: 28459 RVA: 0x002EAFF0 File Offset: 0x002E91F0
	public List<string> a()
	{
		return this.b;
	}

	// Token: 0x06006F2C RID: 28460 RVA: 0x002EAFF8 File Offset: 0x002E91F8
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006F2D RID: 28461 RVA: 0x002EB004 File Offset: 0x002E9204
	public string c()
	{
		return this.a;
	}

	// Token: 0x06006F2E RID: 28462 RVA: 0x002EB00C File Offset: 0x002E920C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006F2F RID: 28463 RVA: 0x002EB018 File Offset: 0x002E9218
	public ar7 b()
	{
		return this.c;
	}

	// Token: 0x06006F30 RID: 28464 RVA: 0x002EB020 File Offset: 0x002E9220
	public void a(ar7 A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006F31 RID: 28465 RVA: 0x002EB02C File Offset: 0x002E922C
	public eo4()
	{
	}

	// Token: 0x06006F32 RID: 28466 RVA: 0x002EB040 File Offset: 0x002E9240
	public eo4(string A_0, List<string> A_1, ar7 A_2)
	{
		this.a = A_0;
		if (A_1 != null)
		{
			this.b.AddRange(A_1);
		}
		this.c = A_2;
	}

	// Token: 0x06006F33 RID: 28467 RVA: 0x002EB074 File Offset: 0x002E9274
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.c != null)
		{
			c5x c5x = this.c.ao() as c5x;
			if (c5x != null && this.b != null && this.b.Count > 0 && c5x.Area != null && c5x.Zone != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
				{
					TypedObjectReference<bag> a_ = serviceOrThrow.aqu().v().c();
					aud aud;
					if (!string.IsNullOrWhiteSpace(this.a))
					{
						aud = c5x.Zone.n(this.a);
					}
					else
					{
						aud = c5x.Area;
					}
					if (aud != null)
					{
						using (List<string>.Enumerator enumerator = this.b.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								string text = enumerator.Current;
								if (!string.IsNullOrWhiteSpace(text))
								{
									cno cno = aud.Divinations.a(text);
									if (cno != null)
									{
										cno.b(a_);
									}
									else
									{
										dux.b(LogSeverity.Warning, "Failed to perform area segment divination. Could not retrieve divination '{0}' in area '{1}'.", new object[]
										{
											text,
											aud.y8()
										});
									}
								}
							}
							return dc4.c;
						}
					}
					dux.b(LogSeverity.Warning, "Failed to perform area segment divination. Could not retrieve target area ('{0}').", new object[]
					{
						string.IsNullOrWhiteSpace(this.a) ? "<current>" : this.a
					});
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x04002D76 RID: 11638
	private new string a;

	// Token: 0x04002D77 RID: 11639
	private List<string> b = new List<string>();

	// Token: 0x04002D78 RID: 11640
	private ar7 c;
}
