﻿/*******************************************************************************
 * SAT4.NET: a SATisfiability library for .NET Copyright (C) 2023, 2004, 2012 Chief Monk, Artois University and CNRS
 *
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 *  http://www.eclipse.org/legal/epl-v10.html
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU Lesser General Public License Version 2.1 or later (the
 * "LGPL"), in which case the provisions of the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of the LGPL, and not to allow others to use your version of
 * this file under the terms of the EPL, indicate your decision by deleting
 * the provisions above and replace them with the notice and other provisions
 * required by the LGPL. If you do not delete the provisions above, a recipient
 * may use your version of this file under the terms of the EPL or the LGPL.
 *
 * Based on the original MiniSat specification from:
 *
 * An extensible SAT solver. Niklas Een and Niklas Sorensson. Proceedings of the
 * Sixth International Conference on Theory and Applications of Satisfiability
 * Testing, LNCS 2919, pp 502-518, 2003.
 *
 * See www.minisat.se for the original solver in C++.
 *
 * Contributors:
 *   CRIL - initial API and implementation
 *******************************************************************************/

namespace Sat4.NET.Core.Specs;

/**
 * That interface allows to efficiently retrieve the truth value of a given
 * variable in the solver.
 * 
 * @author chiefmonk, daniel
 * 
 */
public interface IRandomAccessModel : ISerializable
{
    /**
     * Provide the truth value of a specific variable in the model.
     * 
     * That method should be called deciding that the problem is satisfiable.
     * Else an exception UnsupportedOperationException is launched.
     * 
     * @param variable
     *            the variable id in Dimacs format
     * @return the truth value of that variable in the model
     * @since 1.6
     */
    bool Model(int variable);
}
