using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x0200065B RID: 1627
[eiz("FSW")]
[Serializable]
public sealed class bv9 : oj, ISerializable
{
	// Token: 0x06002947 RID: 10567 RVA: 0x000EB5C0 File Offset: 0x000E97C0
	private bv9(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (c7g)A_0.GetValue("FSW:FS", typeof(c7g));
			return;
		}
		if (base.GetType() == typeof(bv9))
		{
			this.a = (c7g)A_0.GetValue("_FactionSet", typeof(c7g));
			return;
		}
		this.a = (c7g)A_0.GetValue("FactionSetWrapper+_FactionSet", typeof(c7g));
	}

	// Token: 0x06002948 RID: 10568 RVA: 0x000EB65C File Offset: 0x000E985C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("FSW:FS", this.a);
	}

	// Token: 0x06002949 RID: 10569 RVA: 0x000EB670 File Offset: 0x000E9870
	public Dictionary<string, bqi> abr()
	{
		return this.a.abr();
	}

	// Token: 0x0600294A RID: 10570 RVA: 0x000EB680 File Offset: 0x000E9880
	public bv9(c7g A_0)
	{
		czh.a(A_0, "factionSet");
		this.a = A_0;
	}

	// Token: 0x0600294B RID: 10571 RVA: 0x000EB69C File Offset: 0x000E989C
	public bqi abs(string A_0, string A_1, h A_2, bool A_3 = false, exw A_4 = null, bool A_5 = true)
	{
		bqi result;
		try
		{
			result = this.a.abs(A_0, A_1, A_2, A_3, A_4, A_5);
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Error occurred while adding faction with id '{0}'.", new object[]
			{
				A_0
			});
			result = null;
		}
		return result;
	}

	// Token: 0x0600294C RID: 10572 RVA: 0x000EB6F4 File Offset: 0x000E98F4
	public bqi a(string A_0, string A_1, h A_2, bool A_3 = false, exw A_4 = null, bool A_5 = true)
	{
		bqi result;
		try
		{
			bqi bqi = this.abt(A_0);
			if (bqi == null)
			{
				this.abs(A_0, A_1, A_2, A_3, A_4, A_5);
			}
			else
			{
				bqi.b(A_1);
				bqi.a(A_2);
				bqi.a(A_3);
				bqi.a(A_4 ?? new exw());
				bqi.b(A_5);
			}
			result = bqi;
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Error occurred while updating faction with id '{0}'.", new object[]
			{
				A_0
			});
			result = null;
		}
		return result;
	}

	// Token: 0x0600294D RID: 10573 RVA: 0x000EB78C File Offset: 0x000E998C
	public bqi abt(string A_0)
	{
		bqi result;
		try
		{
			result = this.a.abt(A_0);
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Error occurred while retrieving faction with id '{0}'.", new object[]
			{
				A_0
			});
			result = null;
		}
		return result;
	}

	// Token: 0x0600294E RID: 10574 RVA: 0x000EB7DC File Offset: 0x000E99DC
	public cky abu(string A_0, string A_1)
	{
		cky result;
		try
		{
			result = this.a.abu(A_0, A_1);
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Error occurred while retrieving faction relation from '{0}' to '{1}'.", new object[]
			{
				A_0,
				A_1
			});
			result = null;
		}
		return result;
	}

	// Token: 0x0600294F RID: 10575 RVA: 0x000EB830 File Offset: 0x000E9A30
	public h? a(string A_0, string A_1)
	{
		h? result;
		try
		{
			cky cky = this.a.abu(A_0, A_1);
			if (cky != null)
			{
				result = new h?(cky.a);
			}
			else
			{
				result = null;
			}
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Error occurred while retrieving faction relation from '{0}' to '{1}'.", new object[]
			{
				A_0,
				A_1
			});
			result = null;
		}
		return result;
	}

	// Token: 0x06002950 RID: 10576 RVA: 0x000EB8AC File Offset: 0x000E9AAC
	public cky abv(bqi A_0, bqi A_1)
	{
		cky result;
		try
		{
			result = this.a.abv(A_0, A_1);
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Error occurred while retrieving faction relation from '{0}' to '{1}'.", new object[]
			{
				A_0,
				A_1
			});
			result = null;
		}
		return result;
	}

	// Token: 0x06002951 RID: 10577 RVA: 0x000EB900 File Offset: 0x000E9B00
	public cky abw(string A_0, string A_1, h A_2, h? A_3, bool A_4, bool A_5)
	{
		cky result;
		try
		{
			result = this.a.abw(A_0, A_1, A_2, A_3, A_4, A_5);
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Error occurred while setting faction relation from '{0}' to '{1}'.", new object[]
			{
				A_0,
				A_1
			});
			result = null;
		}
		return result;
	}

	// Token: 0x06002952 RID: 10578 RVA: 0x000EB95C File Offset: 0x000E9B5C
	public cky abx(bqi A_0, bqi A_1, h A_2, h? A_3, bool A_4, bool A_5)
	{
		cky result;
		try
		{
			result = this.a.abx(A_0, A_1, A_2, A_3, A_4, A_5);
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Error occurred while setting faction relation from '{0}' to '{1}'.", new object[]
			{
				A_0,
				A_1
			});
			result = null;
		}
		return result;
	}

	// Token: 0x06002953 RID: 10579 RVA: 0x000EB9B8 File Offset: 0x000E9BB8
	public cky a(string A_0, string A_1, h A_2, h? A_3, bool A_4, bool A_5 = false, bool A_6 = false)
	{
		cky result;
		try
		{
			cky cky = this.abu(A_0, A_1);
			if (cky == null)
			{
				this.abw(A_0, A_1, A_2, A_3, false, A_5);
			}
			else if (!A_6)
			{
				cky.b = A_3;
				if (!A_5 || cky.a > A_2)
				{
					cky.a = A_2;
				}
			}
			if (A_4)
			{
				this.a(A_1, A_0, A_2, A_3, false, A_5, A_6);
			}
			result = cky;
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Error occurred while updating faction relation from '{0}' to '{1}'.", new object[]
			{
				A_0,
				A_1
			});
			result = null;
		}
		return result;
	}

	// Token: 0x06002954 RID: 10580 RVA: 0x000EBA64 File Offset: 0x000E9C64
	public void aby(string A_0, string A_1, c2n A_2, object A_3)
	{
		try
		{
			if (A_2 != c2n.a && A_2 != c2n.b)
			{
				bqi bqi = this.abt(A_0);
				bqi bqi2 = this.abt(A_1);
				if (bqi != null && bqi2 != null)
				{
					Dictionary<bqi, h> dictionary = this.a(bqi);
					if (A_2 == c2n.c)
					{
						if (!(A_3 is c1a))
						{
							goto IL_162;
						}
						a7v.a(new eoa(A_0, A_0, A_1, bqi.g()));
						using (Dictionary<bqi, h>.Enumerator enumerator = dictionary.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								KeyValuePair<bqi, h> keyValuePair = enumerator.Current;
								a7v.a(new eoa(A_0, keyValuePair.Key.e(), A_1, keyValuePair.Value));
							}
							goto IL_162;
						}
					}
					if (A_2 == c2n.d)
					{
						h a_ = (h)Math.Max((int)bqi.g(), (int)bqi2.g());
						this.abx(bqi, bqi2, a_, null, bqi2.g() == h.a, true);
						foreach (KeyValuePair<bqi, h> keyValuePair2 in dictionary)
						{
							if (keyValuePair2.Key != bqi2)
							{
								h a_2 = (h)Math.Max((int)keyValuePair2.Value, (int)bqi2.g());
								this.abx(keyValuePair2.Key, bqi2, a_2, null, keyValuePair2.Key.g() == h.a, true);
							}
						}
					}
				}
				IL_162:;
			}
		}
		catch (Exception a_3)
		{
			dux.a(LogSeverity.Error, a_3, "Error occurred while registering hostilities from '{0}' to '{1}'.", new object[]
			{
				A_0,
				A_1
			});
		}
	}

	// Token: 0x06002955 RID: 10581 RVA: 0x000EBC48 File Offset: 0x000E9E48
	public Dictionary<bqi, h> a(bqi A_0)
	{
		Dictionary<bqi, h> dictionary = new Dictionary<bqi, h>();
		foreach (bqi bqi in this.a.abr().Values)
		{
			cky cky = this.a.abv(bqi, A_0);
			if (cky != null && cky.a == h.e && cky.b != null)
			{
				dictionary[bqi] = cky.b.Value;
			}
		}
		return dictionary;
	}

	// Token: 0x06002956 RID: 10582 RVA: 0x000EBCF0 File Offset: 0x000E9EF0
	public h? abz(string A_0, string A_1)
	{
		h? result;
		try
		{
			result = this.a.abz(A_0, A_1);
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Error occurred while retrieving support level for faction '{0}' by faction '{1}'.", new object[]
			{
				A_1,
				A_0
			});
			result = null;
		}
		return result;
	}

	// Token: 0x04001693 RID: 5779
	private c7g a;
}
