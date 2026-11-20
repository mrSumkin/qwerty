using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02001003 RID: 4099
public sealed class bwy : d60
{
	// Token: 0x06005442 RID: 21570 RVA: 0x00254380 File Offset: 0x00252580
	public Guid ab0(b0b A_0, IEnumerable<string> A_1)
	{
		Guid guid = this.a();
		this.a[guid] = A_0;
		if (A_0 != null && A_1 != null)
		{
			foreach (string text in A_1)
			{
				if (text != null)
				{
					this.a(text).Add(A_0);
				}
			}
		}
		return guid;
	}

	// Token: 0x06005443 RID: 21571 RVA: 0x00254400 File Offset: 0x00252600
	public b0b ab1(Guid A_0)
	{
		b0b result;
		this.a.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x06005444 RID: 21572 RVA: 0x00254420 File Offset: 0x00252620
	public List<b0b> ab2(IEnumerable<string> A_0)
	{
		List<b0b> list = new List<b0b>();
		if (A_0 != null)
		{
			foreach (string text in A_0)
			{
				if (text != null)
				{
					HashSet<b0b> hashSet = this.b(text);
					if (hashSet != null)
					{
						list.AddRange(hashSet);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06005445 RID: 21573 RVA: 0x00254494 File Offset: 0x00252694
	public List<b0b> ab3(IEnumerable<string> A_0)
	{
		HashSet<b0b> hashSet = null;
		if (A_0 != null)
		{
			foreach (string text in A_0)
			{
				if (text != null)
				{
					HashSet<b0b> hashSet2 = this.b(text);
					if (hashSet2 == null || hashSet2.Count <= 0)
					{
						break;
					}
					if (hashSet == null)
					{
						hashSet = new HashSet<b0b>(hashSet2);
					}
					else
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(hashSet))
						{
							if (!hashSet2.Contains(b0b))
							{
								hashSet.Remove(b0b);
							}
						}
					}
				}
			}
		}
		if (hashSet != null)
		{
			return Enumerable.ToList<b0b>(hashSet);
		}
		return new List<b0b>();
	}

	// Token: 0x06005446 RID: 21574 RVA: 0x00254588 File Offset: 0x00252788
	public List<b0b> ab4(params string[] A_0)
	{
		return this.ab2(A_0);
	}

	// Token: 0x06005447 RID: 21575 RVA: 0x00254594 File Offset: 0x00252794
	public b0b ab5(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			return Enumerable.FirstOrDefault<b0b>(this.ab4(new string[]
			{
				A_0
			}));
		}
		return null;
	}

	// Token: 0x06005448 RID: 21576 RVA: 0x002545B8 File Offset: 0x002527B8
	public List<b0b> ab6(params string[] A_0)
	{
		return this.ab3(A_0);
	}

	// Token: 0x06005449 RID: 21577 RVA: 0x002545C4 File Offset: 0x002527C4
	public void ab7()
	{
		this.a.Clear();
		this.b.Clear();
	}

	// Token: 0x0600544A RID: 21578 RVA: 0x002545E0 File Offset: 0x002527E0
	public bool ab8(Guid A_0)
	{
		b0b b0b;
		this.a.TryGetValue(A_0, out b0b);
		if (b0b != null)
		{
			foreach (HashSet<b0b> hashSet in this.b.Values)
			{
				hashSet.Remove(b0b);
			}
			this.a.Remove(A_0);
			return true;
		}
		return false;
	}

	// Token: 0x0600544B RID: 21579 RVA: 0x00254664 File Offset: 0x00252864
	public bool ab9(Guid A_0, IEnumerable<string> A_1)
	{
		b0b b0b;
		this.a.TryGetValue(A_0, out b0b);
		if (b0b != null)
		{
			if (A_1 != null)
			{
				foreach (string a_ in A_1)
				{
					HashSet<b0b> hashSet = this.b(a_);
					if (hashSet != null)
					{
						hashSet.Remove(b0b);
					}
				}
			}
			this.a.Remove(A_0);
			return true;
		}
		return false;
	}

	// Token: 0x0600544C RID: 21580 RVA: 0x002546F0 File Offset: 0x002528F0
	private Guid a()
	{
		Guid guid;
		do
		{
			guid = Guid.NewGuid();
		}
		while (this.a.ContainsKey(guid));
		return guid;
	}

	// Token: 0x0600544D RID: 21581 RVA: 0x00254714 File Offset: 0x00252914
	private HashSet<b0b> b(string A_0)
	{
		HashSet<b0b> result;
		this.b.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x0600544E RID: 21582 RVA: 0x00254734 File Offset: 0x00252934
	private HashSet<b0b> a(string A_0)
	{
		HashSet<b0b> hashSet;
		this.b.TryGetValue(A_0, out hashSet);
		if (hashSet == null)
		{
			hashSet = new HashSet<b0b>();
			this.b[A_0] = hashSet;
		}
		return hashSet;
	}

	// Token: 0x0400226E RID: 8814
	private Dictionary<Guid, b0b> a = new Dictionary<Guid, b0b>();

	// Token: 0x0400226F RID: 8815
	private Dictionary<string, HashSet<b0b>> b = new Dictionary<string, HashSet<b0b>>();
}
